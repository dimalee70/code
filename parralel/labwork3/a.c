#include <stdio.h>
#include <string.h>
#include <time.h>
#include <stdlib.h>
#include <ctype.h>

int main (int argc, char** argv)
{
    char symb ;
    unsigned char symb1;
    char *s = "";
    int num=0;
    char * str2;
    int count=0;
    int i=0;
    int sum = 0;


    // FILE file = fopen(argv[1], "r");
    FILE *FileIn= fopen(argv[1], "r");

    if(FileIn == NULL){
        printf("Error opening file");
    }
    //fscanf (file, "%d", &i);    
    // (symb=getc(FileIn))!=EOF
    while ((symb=getc(FileIn))!=EOF)
    {     
        //fscanf (file, "%d", &i);
        //printf ("%d ", i);
        if( isdigit( symb ) != 0 || symb == ' ' || symb == '\n' || symb =='-'){
            size_t len = strlen(s);
            str2 = malloc(len + 1 + 1 );
            strcpy(str2, s);
            str2[len] = symb;
            str2[len + 1] = '\0';
            //strcat( s, symb);
            s = str2;
            //printf("%s",s);
        }
        // if( isdigit(symb) != 0 ){
        //     size_t len = strlen(s);
        //     char *str2 = malloc(len + 1 + 1 );
        //     strcpy(str2, s);
        //     str2[len] = symb;
        //     str2[len + 1] = '\0';
        //     //strcat( s, symb);
        //     printf("%s",s);
        //     }
    }
while (sscanf(s, "%d%n", &num,&i) == 1){
      //printf ("number: %d\n",num);
      sum = sum + num;
      s+=i;
      count++;
}
    printf ("%d\n",sum);
    // while (fgets(buff,1000, file)!=NULL)
    //     printf("%s",buff);
    fclose(FileIn); 
    return 0;
}