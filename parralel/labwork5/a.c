#include <pthread.h>
#include <stdio.h>
#include <stdlib.h>


void *PrintHello(void *threadid)
{
   long tid;
   tid = (long)threadid;
   printf("Hello World! It's me, thread #%ld!\n", tid);
   pthread_exit(NULL);
}

int main(int argc, char *argv[])
{
    int NUM_THREADS = atoi(argv[1]);
    pthread_t threads[NUM_THREADS];
    int rc;
    long t;
    for(t=0;t<NUM_THREADS;t++){
        rc = pthread_create(&threads[t], NULL, PrintHello, (void *)t);
    }

   /* Last thing that main() should do */
    pthread_exit(NULL);
}
