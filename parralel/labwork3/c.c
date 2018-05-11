#include <stdio.h>
#include <string.h>
#include <time.h>
#include <stdlib.h>
#include <ctype.h>

int main (int argc, char** argv)
{
    char symb ;
    char symb1;
    char *s = "";
    int num=0;
    int j = 0;
    int numbers[1000];
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
        if( isdigit( symb ) != 0 || symb == ' ' || symb == '\n' || symb == '-'){
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
while (sscanf(s, "%i%n", &num,&i) == 1){
    numbers[j] = num;
    s+=i;
    count++;
    j++;
}
int n = numbers[0];
int m = numbers[1];
int n2 = 2;
int n3 = n2;
int m2 = 2;
int m3 = m2;
int arr [1000];
int arr2[1000];
int col = 0;
int row = 0;
for(int i = 0; i < n;i++){
    int ar2 [m];
    for (int j =0; j< m; j++){
        ar2[j] = numbers[m2];
        m2++;
    }
    
    for (int y = 0; y< m-1; y++){
        for (int y2 = y+1;y2 < m;y2++){
            if (ar2[y] > ar2[y2]){
                int temp = ar2[y];
                ar2[y] = ar2[y2];
                ar2[y2] = temp;
            }
        }
       
    }
    int temp2 = ar2[0];
    arr[row] = temp2;
    row++;

    // printf("\n");
}
// for (int j =0; j< row; j++){
//     printf("%i",arr[j]);
// }
// printf("\n");


for (int i = 0; i < m;i++){
    int ar [n];
    for (int j = 0;j< n;j++){
        ar[j]=numbers[n2];
        n2 = n2+m;
    }
    for (int y = 0; y< n-1; y++){
        for (int y2 = y+1;y2 < n;y2++){
            if (ar[y] > ar[y2]){
                int temp = ar[y];
                ar[y] = ar[y2];
                ar[y2] = temp;
            }
        }
    }
    int temp3 = ar[0];
    arr2[col] = temp3;
    col++;

    // printf("\n");

    // for (int y = 0; y< n; y++){
    //     printf("%i",ar[y]);
    // }
    // printf("\n");
    n3++;
    n2 = n3;

    
}
// for (int j =0; j< col; j++){
//     printf("%i",arr2[j]);
// }
//3 5    1 2 3 4 5  2 3 4 5 5   3 4 5 -1 5
    //printf ("%d\n",sum);
    // while (fgets(buff,1000, file)!=NULL)
    //     printf("%s",buff);
    fclose(FileIn); 
    FILE * fp;
   /* open the file for writing*/
   fp = fopen ("output.txt","w");
 
   /* write 10 lines of text into the file stream*/
   
    fprintf (fp, "minimum by column: ");
    for(int i = 0; i < col;i++){
        fprintf (fp, "%d ",arr2[i]);
    }
    fprintf (fp, "\n");
    fprintf (fp, "minimum by row: ");
    for(int i = 0; i < row;i++){
        fprintf (fp, "%d ",arr[i]);
   }
   fprintf (fp, "\n");
 
   /* close the file*/  
   fclose (fp);
    return 0;
}