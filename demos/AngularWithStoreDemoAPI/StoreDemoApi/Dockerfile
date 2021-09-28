#the base image yoiu need to run. This includes the sdk.
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
# designate the folder we are working from.
WORKDIR /app
#make port 5000 the designated port for the container.
EXPOSE 80

#designate this variable to be the port you use. which happens to be the same port you exposed above.... coincidence!
ENV ASPNETCORE_URLS=http://*:80

# get a new image (it's the same but for this particular stage) to base this stage on.
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
# setd the folder we're working out of.
WORKDIR /app
#copy this file from outside the container directory to insid eit at this address.
COPY ["Store-Demo-Ui/Store-Demo-Ui.csproj", "Store-Demo-Ui/"]
COPY ["DemoStoreBusinessLayer/DemoStoreBusinessLayer.csproj", "DemoStoreBusinessLayer/"]
COPY ["DemoStoreDbContext/DemoStoreDbContext.csproj", "DemoStoreDbContext/"]
COPY ["ModelsLayer/ModelsLayer.csproj", "ModelsLayer/"]

#restore the .csproj
RUN dotnet restore "Store-Demo-Ui/Store-Demo-Ui.csproj"
# now copy everything.. you see sometimes where they copy just the .csproj file, then copy everything else. YOu don't have to do that 
COPY . .
#change the working directory(folder). this is where the .csproj is located inside the container.
WORKDIR "/app/Store-Demo-Ui"
# now build the .csproj and save it
#RUN dotnet build "Store-Demo-Ui.csproj" -c Release -o /app/build

# explicitly say that we are using the previous stage as this stages base..
#this isn't actually necessary. but it'e dine here to create a new stage and allow the dockerfile to be self documenting.
FROM build AS publish
# run the publish command from the current workdir. 'cause that's where we are!
RUN dotnet publish "Store-Demo-Ui.csproj" -c Release -o /app/publish

# now using the first stage called 'base' to publish. this is a differnt action that the restore and build.
FROM base AS final
#changing the workdir to help the next command.
WORKDIR /app
#now we copy the files created in the publish stage in the (explicitly /app/publish dir.) 
# into the current workdir.
COPY --from=publish /app/publish .
# create a command that's executed when the dockerfile is docker run'd
ENTRYPOINT ["dotnet", "Store-Demo-Ui.dll"]

#command to build the container
# docker build -t markmooredocker/batch08162021docker:storedemobackend .

# command to run
# docker run --env ConnectionStrings__AzureDb="Server=tcp:08162021batch-sqldb-server.database.windows.net,1433;Initial Catalog=08162021batch-sqldb;Persist Security Info=False;User ID=revature-08162021batch;Password=Batch08162021;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" -dp 4200:5000 --name testofapicontainer testofapi