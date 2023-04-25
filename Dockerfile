from mcr.microsoft.com/dotnet/sdk:7.0 AS BUILD
EXPOSE 80

# create working directory where we will put our code

WORKDIR /app

#setup environment

COPY freshCV.csproj/ .

run ls -l
run dotnet restore freshCV.csproj


#copy over the entire app and build an exe file to run the app
#/app/frshCVAPI
COPY freshCVAPI ./
RUN dotnet publish freshCV.csproj -c release -o publishedApp
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
ENV TZ=Africa/Johannesburg
RUN apt-get update
RUN apt-get upgrade -y
RUN apt-get install -y tzdata curl
COPY --from=build /app/publishedApp .
HEALTHCHECK CMD curl --fail http://localhost:80 || exit 1
ENTRYPOINT ["dotnet", "freshCVAPI.dll"]