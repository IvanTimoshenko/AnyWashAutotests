#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM 
WORKDIR /src
COPY ["AnyWashAutotests.csproj", "."]
RUN dotnet restore "./AnyWashAutotests.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "AnyWashAutotests.csproj" -c Release -o /app/build