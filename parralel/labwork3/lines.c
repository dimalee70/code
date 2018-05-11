#include <stdio.h>
#include <string.h>
#include <time.h>
#include <stdlib.h>
#include <ctype.h>

int main (int argc, char** argv)
{
    char symb ;
    char symb1;
    int count1=0;
    int count2 = 0;
    FILE *FileIn= fopen(argv[1], "r");
    FILE *FileIn2= fopen(argv[2], "r");
    if(FileIn == NULL){
        printf("Error opening file");
    }
    while ((symb=getc(FileIn))!=EOF)
    {     
        if(symb == '\n'){
            count1++;
        }
    }
    while ((symb1=getc(FileIn2))!=EOF)
    {     
        if(symb1 == '\n'){
            count2++;
        }
    }
    printf("%d %d\n",count1,count2);
    fclose(FileIn); 
    return 0;
}