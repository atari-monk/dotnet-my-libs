#this generates local nugets from my libs in this sln
$path = "C:\atari-monk\nugets";

#libs independent from my libs 
$libs0 = 'DotNetTool', 'Connection.Builder', 'DIHelper', 'CommandDotNet.IoC.Unity', 'DotNetExtension';
#libs dependent on libs0
$libs1 = 'Config.Wrapper', 'CLIHelper', 'ModelHelper';
#libs dependent on libs0 and/or libs1
$libs2 = 'EFCore.Helper', 'Serilog.Wrapper', 'CommandDotNet.Helper', 'CommandDotNet.Unity.Helper', 'CommandDotNet.MDI.Helper', 'DataToTable', 'Better.Console.Tables.TestApp', 'CRUDCommandHelper', 'CLIReader', 'CLIWizardHelper', 'CLIFramework';

$libs = $libs0 + $libs1 + $libs2;

Set-Location ..

dotnet nuget locals all --clear
dotnet nuget locals temp -c
dotnet nuget locals global-packages -c
dotnet restore

foreach ($lib in $libs) {
  Set-Location $lib

  dotnet pack -c Release -o $path
  
  Set-Location ..
}