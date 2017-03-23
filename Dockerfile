FROM microsoft/aspnetcore:1.0.4
WORKDIR /app
COPY app/bin/Debug/netcoreapp1.0/publish /app
ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000
 
ENTRYPOINT /bin/bash -c "dotnet SecretHiplerServer.dll"