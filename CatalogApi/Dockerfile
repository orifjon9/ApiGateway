FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /dotnetapp
COPY ./bin/Docker .
ENV ASPNETCORE_URLS http://*:7001
ENV ASPNETCORE_ENVIRONMENT Development
ENTRYPOINT dotnet CatalogApi.dll