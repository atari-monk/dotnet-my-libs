
#generate nugets of my libs dependent on my independent libs
$libs = 'Config.Wrapper', 'CLIHelper', 'ModelHelper'

#up from script dir
cd ..

foreach ($lib in $libs) {
  cd $lib
  dotnet pack -c Release -o C:\atari-monk\nugets
  #up from lib dir
  cd ..
}
