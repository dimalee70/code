#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(){
    int arr [5];
    int *arr2 [5];
    int a; 
    int *pi;
    char name[] = "Steve Jobs";
    printf("Enter 5 numbers : \n");
    for (int i = 0; i < 5 ; i++){
        scanf("%d", &arr[i]);
        pi = &arr[i];
        *pi = arr[i];
        arr2[i] = pi;
    }
    for(int i = 4; i >= 0; i--){
        printf("value = %d, adress = %p \n",*arr2[i],arr2[i]);
    }
    return 0;
}