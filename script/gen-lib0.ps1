
#generate nugets of my libs independent from my other libs 
$libs = 'DIHelper', 'CommandDotNet.IoC.Unity'

#up from script dir
cd ..

foreach ($lib in $libs) {
  cd $lib
  dotnet pack -c Release -o C:\atari-monk\nugets
  #up from lib dir
  cd ..
}
