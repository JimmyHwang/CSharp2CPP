#pragma once
#ifndef MIXED_MODE_MULTIPLY_HPP
#define MIXED_MODE_MULTIPLY_HPP

extern "C"
{
  // YourCallback is now a function that takes in 2 ints and returns void
  typedef void(__stdcall * YourCallback)(int, int);

  __declspec(dllexport) int __stdcall Multiply(int a, int b);
  __declspec(dllexport) int __stdcall Addition(int a, int b);
  __declspec(dllexport) int __stdcall Get1(int index);
  __declspec(dllexport) void __stdcall Set1(int index, int data);
  __declspec(dllexport) void __stdcall TakesInCallbackAndDoesStuff(YourCallback yourCallback);
}
#endif