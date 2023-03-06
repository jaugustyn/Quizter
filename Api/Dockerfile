FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["QuizterAPI/QuizterAPI.csproj", "QuizterAPI/"]
RUN dotnet restore "QuizterAPI/QuizterAPI.csproj"
COPY . .
WORKDIR "/src/QuizterAPI"
RUN dotnet build "QuizterAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QuizterAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QuizterAPI.dll"]
