#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://audratalks.com/openapi.yaml -o openapi.yaml

autosdk generate openapi.yaml \
  --namespace Audra \
  --clientClassName AudraClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --api-key-env AUDRA_API_KEY \
  --ignore-openapi-errors \
  --exclude-deprecated-operations
