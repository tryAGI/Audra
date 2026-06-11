#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://audratalks.com/openapi.yaml -o openapi.yaml

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
