dotnet restore;
dotnet build -c Release;
dotnet pack --no-build -c Release NyceSharp/NyceSharp.csproj;

$nupkg = (Get-ChildItem NyceSharp/bin/Release/*.nupkg)[0];

# Push the nuget package to AppVeyor's artifact list.
Push-AppveyorArtifact $nupkg.FullName -FileName $nupkg.Name -DeploymentName "NyceSharp.nupkg"