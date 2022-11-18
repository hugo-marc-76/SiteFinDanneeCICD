FROM mcr.microsoft.com/dotnet/sdk:6.0 AS nwsinventaire
ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet --list-runtimes
COPY ./Server/bin/Release/net6.0/publish/ /app
WORKDIR /app
EXPOSE 5000

CMD ["dotnet --list-runtimes"]
ENTRYPOINT ["dotnet", "NWSInventaire.Server.dll", "--urls=\"http://0.0.0.0:5000\""]