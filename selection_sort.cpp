#include <iostream>
using namespace std;

void selectionSort(int* array, int size) {
    int index = 0;
    int min = 0;
    int temp;
    for (int i = 0; i < size ; i++) {
        min = index;
        for (int j = 0; j < size - index; j++) {
            if (array[min] > array[index + 1 + j])
                min = j + 1 + index;

        }
        temp = array[min];
        array[min] = array[index];
        array[index] = temp;
        index++;
    }
}
void print(int* array, int size) {
    for (int i = 0; i < size; i++) {
        cout << array[i] << " ";
    }
}

int main()
{
    int size = 0;
    cout << "Eleman sayisini giriniz: ";
    cin >> size;
    int* array = new int[size];
    cout << "Elemanlari giriniz: ";
    for (int i = 0; i < size; i++) {
        cin >> array[i];
    }
    selectionSort(array, size);
    print(array, size);
}