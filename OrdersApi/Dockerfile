FROM microsoft/dotnet:2.1-aspnetcore-runtime as base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk as build
WORKDIR /src
COPY OrdersApi/OrdersApi.csproj OrdersApi/
RUN dotnet restore OrdersApi/OrdersApi.csproj
COPY . .
WORKDIR /src/OrdersApi
RUN dotnet build OrdersApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish OrdersApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OrdersApi.dll"]