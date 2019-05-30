// This is the main DLL file.

#include "stdafx.h"

#include "Math.h"

__declspec(dllexport) float Add(float a, float b)
{
	return a + b;
}
