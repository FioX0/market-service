﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["lib9c/Lib9c/Lib9c.csproj", "lib9c/Lib9c/"]
COPY ["NineChronicles.RPC.Shared/NineChronicles.RPC.Shared/NineChronicles.RPC.Shared.csproj", "NineChronicles.RPC.Shared/NineChronicles.RPC.Shared/"]
COPY ["MarketService/MarketService.csproj", "MarketService/"]
COPY . ./
WORKDIR "/src"
FROM build AS publish
RUN dotnet publish "MarketService/MarketService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarketService.dll"]
