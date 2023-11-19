using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RifLoader.Huffman
{
    internal class Huffman
    {
        public static void MakeHuffmanDecodeTable(byte[] codeLengthCount, int maxDepth, byte[] byteAssignment)
        {
            // 1 << 11 = 2048
            int tableLength = 1 << maxDepth;

            Console.WriteLine("Table Length: " + tableLength);

            int[] decodeTable = new int[tableLength];

            int thisdepth = 0;
            int depthbit = 4;
            int repcount = 1 << maxDepth; // 2048
            int repspace = 1;
            int lenbits = 0;
            
            // In original code un-initialized
            int temp = 0;
            int count = 0;


        }
    }
}
