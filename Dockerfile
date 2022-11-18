FROM mcr.microsoft.com/dotnet/sdk:6.0 AS nwsinventaire
RUN echo $(ls -lah)
WORKDIR /src
COPY . .
EXPOSE 5000

ENTRYPOINT ["dotnet", "NWSInventaire.Server"]