
#generate all nugets of all my libs in correct order
$path = "C:\atari-monk\nugets";

#generate nugets of my libs independent from my other libs 
$libs0 = 'DotNetTool', 'DIHelper', 'CommandDotNet.IoC.Unity', 'DotNetExtension'
#generate nugets of my libs dependent on my independent libs
$libs1 = 'Config.Wrapper', 'CLIHelper', 'ModelHelper'
#generate nugets of my libs dependent on my dependent libs
$libs2 = 'EFCore.Helper', 'Serilog.Wrapper', 'CommandDotNet.Helper', 'CommandDotNet.Unity.Helper', 'CommandDotNet.MDI.Helper', 'DataToTable', 'Better.Console.Tables.TestApp', 'CRUDCommandHelper', 'CLIReader', 'CLIWizardHelper', 'CLIFramework'

#up from script dir
Set-Location ..

foreach ($lib in $libs0 + $libs1 + $libs2) {
  Set-Location $lib
  dotnet pack -c Release -o $path
  #up from lib dir
  Set-Location ..
}