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
fetch_spec -o openapi.yaml https://api.novu.co/openapi.json

# Fix auth: convert apiKey to http/bearer and add top-level security array
jq '
  .components.securitySchemes = {
    "BearerAuth": {
      "type": "http",
      "scheme": "bearer"
    }
  } |
  .security = [{"BearerAuth": []}]
' openapi.yaml > openapi.fixed.yaml
mv openapi.fixed.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace Novu \
  --clientClassName NovuClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
