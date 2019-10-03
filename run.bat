@ECHO OFF
dotnet clean
dotnet restore
dotnet build
dotnet run --no-build --no-restore --project 00-Programa\Simasoft.Challenges.SortFeliz.UI\