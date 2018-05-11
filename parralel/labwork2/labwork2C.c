/* strtok example */
#include <stdio.h>
#include <string.h>
#include <time.h>
#include <stdlib.h>
#include <ctype.h>

int main ()
{

  char article[5][10] = {"the","a","one","some","any"};
  char noun[5][10] = { "boy","girl", "dog","town","car"};
  char verb[5][10] = {"drove","jumped","ran","walked","skipped"};
  char preposition[5][10] = {"to","from","over","under","on"};
  int size;
  time_t ti;
   
  size = 5;
   
   /* Intializes random number generator */
  srand((unsigned)time(&ti));

   /* Print 5 random numbers from 0 to 49 */
   for( int i = 0 ; i < 20 ; i++ ) {
     int temp = rand() % size;
     article[temp][0] = (char)((int)article[temp][0]-32);
     printf("%s ",article[temp]);
      article[temp][0] = (char)((int)article[temp][0]+32);
     printf("%s ",noun[rand() % size]);
     printf("%s ",verb[rand() % size]);
     printf("%s ",preposition[rand() % size]);
     printf("%s ",article[rand() % size]);
     printf("%s. \n",noun[rand() % size]);
   }
   //article, noun, verb, preposition, article and noun
   
  return 0;
}