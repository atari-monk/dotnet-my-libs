
#generate nugets of my libs independent from my other libs 
$path = 'lib0'
$libs = 'DIHelper'

#up from script dir
cd ..

foreach ($lib in $libs) {
  cd "${path}/${lib}"
  dotnet pack -c Release -o C:\atari-monk\nugets
  #up from lib dir
  cd ../..
}
