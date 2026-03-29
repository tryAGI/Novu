dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.novu.co/openapi.json

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
