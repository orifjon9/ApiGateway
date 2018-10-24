FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /dotnetapp-gatewayapi
COPY ./bin/Docker .
ENV ASPNETCORE_URLS http://*:7000
ENV ASPNETCORE_ENVIRONMENT Development
ENTRYPOINT dotnet GatewayApi.dll