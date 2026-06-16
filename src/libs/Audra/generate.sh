#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error --location https://audratalks.com/openapi.yaml -o openapi.yaml

python3 - <<'PY'
from pathlib import Path

path = Path("openapi.yaml")
text = path.read_text()

if "    UsageResponse:\n" not in text:
    raise RuntimeError("UsageResponse schema not found in openapi.yaml")

usage_start = text.index("    UsageResponse:\n")
usage_end = text.index("\n\n    SpeechRequest:", usage_start)
prefix = text[:usage_start]
usage = text[usage_start:usage_end]
suffix = text[usage_end:]

usage = usage.replace(
    "        credits_chars:\n          type: integer\n",
    "        credits_chars:\n          type: integer\n          nullable: true\n",
    1,
)

if "        api_key_prefix:\n" not in usage:
    usage = usage.replace(
        "        premium_voicepacks_enabled:\n          type: boolean",
        "        premium_voicepacks_enabled:\n"
        "          type: boolean\n"
        "        api_key_prefix:\n"
        "          type: string\n"
        "          description: Prefix of the API key used for this request.\n"
        "        unlimited:\n"
        "          type: boolean\n"
        "          description: Whether the account has unlimited character credits.",
    )

text = f"{prefix}{usage}{suffix}"

if "        api_key_prefix:\n" not in text or "        unlimited:\n" not in text:
    raise RuntimeError("UsageResponse compatibility fields were not applied")

path.write_text(text)
PY

autosdk generate openapi.yaml \
  --namespace Audra \
  --clientClassName AudraClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --api-key-env AUDRA_API_KEY \
  --ignore-openapi-errors \
  --exclude-deprecated-operations

rm -rf ../../cli/Audra.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Audra.CLI \
  --sdk-project ../../libs/Audra/Audra.csproj \
  --targetFramework net10.0 \
  --namespace Audra \
  --clientClassName AudraClient \
  --package-id Audra.CLI \
  --tool-command-name audra \
  --user-secrets-id Audra.CLI \
  --api-key-env-var AUDRA_API_KEY \
  --base-url-env-var AUDRA_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer \
  --ignore-openapi-errors
