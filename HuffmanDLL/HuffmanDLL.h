#pragma once

#ifdef HUFFMANDLL_EXPORTS
	#define HUFFMANDLL_API __declspec(dllexport)
#else
	#define HUFFMANDLL_API __declspec(dllimport)
#endif


#ifdef __cplusplus
extern "C" {
#endif

	HUFFMANDLL_API int huffman_get_version();

#ifdef __cplusplus
}
#endif