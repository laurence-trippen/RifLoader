huffman-mingw.dll: huffman.o
	gcc -o huffman-mingw.dll huffman.o -s -shared -Wl,--subsystem,console

huffman.o: huffman.c
	gcc -c -o huffman.o huffman.c -D HUFFMAN_DLL_EXPORTS

