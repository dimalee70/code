#include <stdio.h>
#include <string.h>
int main( ) {

   char str[100];
   int arr [10];
   char *token;
   printf( "Enter a text :");
   fgets(str, 100, stdin); 
   for(int i = strlen(str);i >= 0;i--){
       printf("%c",str[i]);
   } 
   printf("\n");

   return 0;
}
