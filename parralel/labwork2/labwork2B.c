/* strtok example */
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main ()
{
  char str[1000];
  char * tok;
  int n [1000];
  int t = 0;
  printf( "Enter numbers :");
  fgets(str, 100, stdin);
  tok = strtok (str," ");
  int s;
  while (tok != NULL)
  {
    
    int num = atoi(tok);
    n[t] = num;
    t++;
    tok = strtok (NULL, " ");
  }
  for (int i = 0; i < t-1;i++){
    for (int j = i +1; j < t;j++){
        if(n[i] > n[j]){
          int temp = n[i];
          n[i] = n[j];
          n[j] =temp;
        }
    }
  }
  for (int i = 0; i < t; i ++){
    printf("%d ",n[i]);
  }
  printf("\n");
  return 0;
}