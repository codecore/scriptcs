using System;
using System.Collections.Generic;
using System.IO;
using Utilities;

namespace ScriptCs
{
    public class FileSystem : IFileSystem
    {
        public IEnumerable<string> EnumerateFiles(string dir, string searchPattern)
        {
            Verify.Parameters(dir, searchPattern);
            return Directory.EnumerateFiles(dir, searchPattern, SearchOption.AllDirectories);
        }

        public void Copy(string source, string dest, bool overwrite)
        {
            Verify.Parameters(source, dest);
            File.Copy(source, dest, overwrite);
        }

        public bool DirectoryExists(string path)
        {
            Verify.Parameters(path);
            return Directory.Exists(path);
        }

        public void CreateDirectory(string path)
        {
            Verify.Parameters(path);
            Directory.CreateDirectory(path);
        }

        public string ReadFile(string path)
        {
            Verify.Parameters(path);
            return File.ReadAllText(path);
        }

        public string[] ReadFileLines(string path)
        {
            Verify.Parameters(path);
            return File.ReadAllLines(path);
        }

        public bool IsPathRooted(string path)
        {
            Verify.Parameters(path);
            return Path.IsPathRooted(path);
        }

        public string CurrentDirectory
        {
            get { return Environment.CurrentDirectory; }
        }

        public string NewLine
        {
            get { return Environment.NewLine; }
        }

        public DateTime GetLastWriteTime(string file)
        {
            Verify.Parameters(file);
            return File.GetLastWriteTime(file);
        }

        public void Move(string source, string dest)
        {
            Verify.Parameters(source, dest);
            File.Move(source, dest);
        }

        public bool FileExists(string path)
        {
            Verify.Parameters(path);
            return File.Exists(path);
        }

        public Stream CreateFileStream(string filePath, FileMode mode)
        {
            Verify.Parameters(filePath);
            return new FileStream(filePath, mode);
        }

        public string GetWorkingDirectory(string path)
        {
            Verify.Parameters(path);
            return IsPathRooted(path) ? Path.GetDirectoryName(path) : CurrentDirectory;
        }
    }
}
