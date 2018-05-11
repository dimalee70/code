#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(){
    int arr [10];
    int a; 
    int *pi;
    char name[] = "Steve Jobs";
    printf("Enter 10 numbers : \n");
    for (int i = 0; i < 10 ; i++){
        if(i == 9){
            pi = &a;
            *pi = a;
              printf("The memory address of a is: %p\n", pi);
        }
        scanf("%d", &a);
        arr[i] = a;
    }
    for(int i = 9; i >= 0; i = i - 2){
        pi = &arr[i];
        *pi = arr[i];
        printf("value = %d, adress = %p \n", arr[i],pi);
    }

    
    return 0;
}