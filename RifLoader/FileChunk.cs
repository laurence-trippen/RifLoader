using CH.Compressor.Huffman;
using System.Text;

namespace RifLoader
{
    public class FileChunk
    {
        public const string COMPRESSED_RIF_IDENTIFIER = "REBCRIF1";
        public const string UNRECOGNIZED_RIF_IDENTIFIER = "REBINFF2";

        private byte[]? data = null;
        private bool isCompressed = false;

        public FileChunk(string rifPath)
        {
            if (!File.Exists(rifPath))
                throw new Exception("Couldn't find RIF file: " + rifPath);

            this.data = File.ReadAllBytes(rifPath);

            string rifId = Encoding.ASCII.GetString(GetByteSpan(0, 8));

            Console.WriteLine("RIF ID: " + rifId);

            this.isCompressed = rifId == COMPRESSED_RIF_IDENTIFIER;

            Console.WriteLine("RIF COMPRESSED: " + this.isCompressed);

            // var compressor = new HuffmanCompressor();

            ExtractHuffmanPackage();
        }

        private void ExtractHuffmanPackage()
        {
            // 8  byte  - char Identifier[8];
            // 4  byte  - int CompressedDataSize;
            // 4  byte  - int UncompressedDataSize;
            // 44 byte  - int CodelengthCount[11];
            // 256 byte - unsigned char ByteAssignment[256];

            // 316 bytes total

            int compressedDataSize = BitConverter.ToInt32(GetByteSpan(8, 4));
            int uncompressedDataSize = BitConverter.ToInt32(GetByteSpan(12, 4));

            byte[] codelengthCount = GetByteSpan(16, 44);
            byte[] byteAssignment = GetByteSpan(60, 256);

            Console.WriteLine("Compressed data size: " + compressedDataSize);
            Console.WriteLine("Un Compressed data size: " + uncompressedDataSize);

            Huffman.Huffman.MakeHuffmanDecodeTable(codelengthCount, 11, byteAssignment);
        }

        private byte[] GetByteSpan(int offset, int length)
        {
            if (this.data == null)
            {
                throw new Exception("Invalid RIF data!");
            }

            byte[] span = new byte[length];

            for (int i = 0; i < length; i++)
            {
                span[i] = this.data[offset + i];
            }

            return span;
        }
    }
}
