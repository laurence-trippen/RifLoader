#include "../HuffmanDLL-mingw/huffman.h"

#include <stdio.h>
#include <stdlib.h>

int main(void) {
  printf("test\n");
  
  int version = huffman_get_version();

  printf("%d\n", version);

  return EXIT_SUCCESS;
}
