#the base image yoiu need to run. This includes the sdk.
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
# designate the folder we are working from.
WORKDIR /app
#make port 5000 the designated port for the container.
EXPOSE 5000

#designate this variable to be the port you use. which happens to be the same port you exposed above.... coincidence!
ENV ASPNETCORE_URLS=http://+:5000

# get a new image (it's the same but for this particular stage) to base this stage on.
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
# setd the folder we're working out of.
WORKDIR /src
#copy this file from outsid ethe container directory to insid eit at this address.
COPY ["Store-Demo-Ui/Store-Demo-Ui.csproj", "Store-Demo-Ui/"]
#restore the .csproj
RUN dotnet restore "Store-Demo-Ui\Store-Demo-Ui.csproj"
#now copy everything.. this isn't really necessary...
COPY . .
#change the working directory(folder). this is where the .csproj is located inside the container.
WORKDIR "/src/Store-Demo-Ui"
# now run the .csproj. notice the path is simple because you designated this directory as the 'workdir'
RUN dotnet build "Store-Demo-Ui.csproj" -c Release -o /app/build

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
