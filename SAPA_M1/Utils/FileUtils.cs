using System;

namespace Utils
{
    public static class FileUtils
    {
        public static string GetAbsExePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
