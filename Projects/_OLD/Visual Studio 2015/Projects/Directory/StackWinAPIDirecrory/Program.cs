using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace StackWinAPIDirecrory
{
    class Program
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        struct WIN32_FIND_DATA
        {
            public uint dwFileAttributes;
            public long ftCreationTime;
            public long ftLastAccessTime;
            public long ftLastWriteTime;
            public uint nFileSizeHigh;
            public uint nFileSizeLow;
            private uint dwReserved0;
            private uint dwReserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string cFileName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string cAlternateFileName;
        }

        private const string KERNEL32 = "kernel32.dll";

        [DllImport(KERNEL32, SetLastError = true, CharSet = CharSet.Unicode)]
        static extern IntPtr FindFirstFile(
            string lpFileName,
            ref WIN32_FIND_DATA lpFindFileData
            );

        [DllImport(KERNEL32, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FindNextFile(
            IntPtr hFindFile,
            out WIN32_FIND_DATA lpFindFileData
            );

        [DllImport(KERNEL32, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FindClose(
            IntPtr hFindFile
            );

        static List<string> CreateTree(string Dir, bool SubDir)
        {
            const string unicode_version = @"\\?\";

            var stack = new Stack<string>();
            var list = new List<string>();
            var wfd = new WIN32_FIND_DATA();
            IntPtr hFile;

            stack.Push(Dir);

            do
            {
                string path;

                do
                {
                    list.Add(Dir = stack.Pop());
                    path = unicode_version + Path.Combine(Dir, "*");
                    hFile = FindFirstFile(path, ref wfd);
                } while (hFile == (IntPtr)(-1));

                do
                {
                    if (wfd.cFileName == "." || wfd.cFileName == "..")
                        continue;

                    path = Path.Combine(Dir, wfd.cFileName);

                    if ((wfd.dwFileAttributes & 0x10) != 0 && SubDir)
                        stack.Push(path);
                    else
                        list.Add(path);
                } while (FindNextFile(hFile, out wfd));

                FindClose(hFile);
            } while (stack.Count != 0);

            return list;
        }

        static void Main(string[] args)
        {

            foreach (var item in CreateTree(@"d:\", true))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
