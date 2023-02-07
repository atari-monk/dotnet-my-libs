using GitPath.ConsoleApp;
using GitPath.Lib;
using Unity;

var bootstraper = new GitPathBootstraper();
var container = bootstraper.Boot();
var gitPath = container.Resolve<IGitPath>();
Console.WriteLine(gitPath.GetGitPath(args[0]));