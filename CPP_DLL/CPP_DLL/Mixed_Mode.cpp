#include "Mixed_Mode.h"

int Data;

void main() {

}

int Multiply (int a, int b) {
  return a * b;
}

int Addition(int a, int b) {
  return a + b;
}

int Get1(int index) {
  return Data;
}

void Set1(int index, int data) {
  Data = data;
}



// this says that it will be exported
void TakesInCallbackAndDoesStuff(YourCallback yourCallback) {
  // do stuff
  yourCallback(1, 3);
}