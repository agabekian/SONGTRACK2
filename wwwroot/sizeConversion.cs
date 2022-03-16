using System;
namespace cSharp2022
{
    public class Calculate
    {
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        double len = new FileInfo(filename).Length;
        int order = 0;
        while (len >= 1024 && order<sizes.Length - 1) 
        {
            order++;
        }
len = len / 1024;
}

}