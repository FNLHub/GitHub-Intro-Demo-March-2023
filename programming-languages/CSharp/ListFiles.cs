
// C# program to listing the files in a directory
using System;
using System.IO;
 
class GFG{
     
static void Main(string[] args)
{
     
    // Get the directory
    DirectoryInfo place = new DirectoryInfo(@"C:\Train");
     
    // Using GetFiles() method to get list of all
    // the files present in the Train directory
    FileInfo[] Files = place.GetFiles();
    Console.WriteLine("Files are:");
    Console.WriteLine();
     
    // Display the file names
    foreach(FileInfo i in Files)
    {
        Console.WriteLine("File Name - {0}", i.Name);
    }
}
}