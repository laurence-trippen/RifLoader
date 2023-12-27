using System.Runtime.InteropServices;

namespace RifLoader.HuffmanDLL
{
    internal class HufmanDllAPI
    {
        [DllImport("HuffmanDLL.dll")]
        public static extern int huffman_get_version();
    }
}
