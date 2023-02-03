
#generate nugets of my libs dependent on my independent libs
$path = 'lib1'
$libs = 'Config.Wrapper', 'CLIHelper'

#up from script dir
cd ..

foreach ($lib in $libs) {
  cd "${path}/${lib}"
  dotnet pack -c Release -o C:\atari-monk\nugets
  #up from lib dir
  cd ../..
}
