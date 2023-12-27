using System.Runtime.InteropServices;

namespace RifLoader.HuffmanDLL
{
    // Struct representing HuffmanPackage
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HuffmanPackage
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string Identifier;

        public int CompressedDataSize;
        public int UncompressedDataSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public int[] CodelengthCount;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] ByteAssignment;
    }

    public static class HuffmanDllAPI
    {
        [DllImport("HuffmanDLL.dll")]
        public static extern IntPtr HuffmanDecompress(ref HuffmanPackage inpackage);
    }
}
