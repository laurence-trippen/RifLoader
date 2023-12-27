#include "../HuffmanDLL-mingw/huffman.h"

#include <stdio.h>
#include <stdlib.h>

int main(void) {
  int version = huffman_get_version();

  printf("test\n");
  printf("%d\n", version);

  return EXIT_SUCCESS;
}
