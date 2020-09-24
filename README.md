# Protocol
ASTM UTM Protocol (API and sequence diagrams)

## Viewing locally
To view this YAML file locally:

```shell script
docker run -it --rm -p 8080:8080 \
  -v $(pwd)/utm.yaml:/usr/share/nginx/html/swagger.yaml \
  -e PORT=8080 -e SPEC_URL=swagger.yaml redocly/redoc
```

...then visit [http://localhost:8080/](http://localhost:8080/) in a browser.
