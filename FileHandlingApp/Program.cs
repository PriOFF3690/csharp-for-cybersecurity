using System;
using System.IO; // for file handling

class Program
{
    static void Main()
    {
        /*
            File Handling:
                - File handling in C# allows developers to create, read, write and manage files stored on disk. 
                - The .NET Framework provides the System.IO namespace, which contains classes and methods for performing these operations in a simple and efficient way.

                C# uses the System.IO namespace for file and directory operations. Commonly used classes include:
                    - File: Provides static methods for creating, copying, deleting, moving and opening files.
                    - FileInfo: Provides instance methods for file operations with additional objec t-oriented features.
                    - Directory: Provides static methods for creating, moving and enumerating directories.
                    - DirectoryInfo: Provides instance methods for directory operations.
                    - StreamReader / StreamWriter: For reading and writing text files.
                    - BinaryReader / BinaryWriter: For reading and writing binary files.
                    - FileStream: For reading and writing to files at a lower level.
        */   

        
        // Creating Directory
        if (!Directory.Exists("Test"))
        {
            Directory.CreateDirectory("Test");
            Console.WriteLine("Test Directory created.");
        }
        else
        {
            Console.WriteLine("\nTest Directory Exists.");
        }   
        
        string file = ".\\Test\\test.txt";
        if (!File.Exists(file))
        {
            File.Create(file); // creating file.
            Console.WriteLine("\nFile Created: test.txt");
            Console.WriteLine("Run again");
            return;
        }
        else
        {
            Console.WriteLine("\nFile Exists: test.txt");
        }
        
        // Writing into file;
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("This is the first line");
            writer.WriteLine("This is the second line");
        }
        Console.WriteLine("Data written to file.");
        // Reading file;
        using (StreamReader reader = new StreamReader(file))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("\nContent of the file:");
            Console.WriteLine(content);
        }
        // Append text to file
        File.AppendAllText(file,"This line is appended");
        Console.WriteLine("Appending to the file:");
        Console.WriteLine(File.ReadAllText(file));

        // Print FileInfo
        FileInfo fileInfo = new FileInfo(file);
        string filename = fileInfo.FullName;
        DateTime lastAccessTime = fileInfo.LastAccessTime;
        DateTime creationTime = fileInfo.CreationTime;
        DateTime lastWriteTime = fileInfo.LastWriteTime;
        string extension = fileInfo.Extension;

        Console.WriteLine("\nFile Details:");
        Console.WriteLine("Full Name: "+filename);
        Console.WriteLine("File Extension: "+extension);
        Console.WriteLine("\nCreation Time: "+creationTime);
        Console.WriteLine("Last Access Time: "+lastAccessTime);
        Console.WriteLine("Last Write Time: "+lastWriteTime);
    }
}