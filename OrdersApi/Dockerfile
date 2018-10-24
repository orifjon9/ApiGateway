FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /dotnetapp-ordersapi
COPY ./bin/Docker .
ENV ASPNETCORE_URLS http://*:7002
ENV ASPNETCORE_ENVIRONMENT Development
ENTRYPOINT dotnet OrdersApi.dll