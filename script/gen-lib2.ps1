
#generate nugets of my libs dependent on my dependent libs
$libs = 'EFCore.Helper', 'Serilog.Wrapper', 'CommandDotNet.Helper', 'CommandDotNet.Unity.Helper', 'DataToTable', 'Better.Console.Tables.TestApp', 'CRUDCommandHelper', 'CLIReader', 'CLIWizardHelper', 'CLIFramework'

#up from script dir
cd ..

foreach ($lib in $libs) {
  cd $lib
  dotnet pack -c Release -o C:\atari-monk\nugets
  #up from lib dir
  cd ..
}
