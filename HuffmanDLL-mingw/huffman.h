// Define 'HUFFMAN_DLL_EXPORTS' only if building the DLL.
#ifdef HUFFMAN_DLL_EXPORTS
  #define HUFFMAN_DLL_API __declspec(dllexport)
#else
  #define HUFFMAN_DLL_API __declspec(dllimport)
#endif


#ifdef __cplusplus
extern "C" {
#endif

int HUFFMAN_DLL_API __cdecl huffman_get_version(void);

#ifdef __cplusplus
}
#endif
