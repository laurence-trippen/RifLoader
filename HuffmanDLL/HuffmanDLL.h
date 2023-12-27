#pragma once

#ifdef HUFFMANDLL_EXPORTS
	#define HUFFMANDLL_API __declspec(dllexport)
#else
	#define HUFFMANDLL_API __declspec(dllimport)
#endif


#ifdef __cplusplus
extern "C" {
#endif


	#define COMPRESSED_RIF_IDENTIFIER "REBCRIF1"
	#define MAX_DEPTH 11


	typedef struct
	{
		char			Identifier[8];
		int				CompressedDataSize;
		int				UncompressedDataSize;
		int				CodelengthCount[MAX_DEPTH];
		unsigned char	ByteAssignment[256];
	} HuffmanPackage;


	HUFFMANDLL_API HuffmanPackage* HuffmanCompression(unsigned char* sourcePtr, int length);

	HUFFMANDLL_API char* HuffmanDecompress(const HuffmanPackage* inpackage);


#ifdef __cplusplus
}
#endif