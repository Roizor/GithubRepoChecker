using System;
using System.IO;
using System.Collections;

public class GithubRepoChecker
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Checking directory for directories w/ git repos");
        IEnumerable<string> enumDir = Directory.EnumerateDirectories(args[0]);
        foreach (string dir in enumDir)
        {
            IEnumerable<string> enumGitFolder = Directory.EnumerateDirectories(dir);
            if (enumGitFolder.Contains(".git"))
            {
                Console.WriteLine(dir + "has a git repo");
            } else
            {
                Console.WriteLine(dir + "does not have a git repo");
            }
        }
    }
}