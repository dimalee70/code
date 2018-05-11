// https://www.geeksforgeeks.org/sum-array-using-pthreads/

#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <semaphore.h>

int n;
int * globalArr;
int * numberArray;
int sizeOfGlobalArray;
int threadSize;
int curentThread = 0;
int part = 0;
sem_t semaphore;

// tid = pthread_getthreadid_np();
void* sumFromArray(void* args)
{
    
    
    // Each thread computes sum of 1/4th of array
    // int thread_part = part++;
    // sem_wait(&semaphore);
    int thread_part = part;
    
    for (int i = (thread_part) * (sizeOfGlobalArray); i < ((thread_part +1 ) * (sizeOfGlobalArray)); i++){
        // sem_wait(&semaphore);
        globalArr[part] += numberArray[i];
        // sem_post(&semaphore); 
    }
    // printf("Current thread %d\n",thread_part);
    part++;
    // sem_post(&semaphore);
    
  
   
    
}
int main(){
    
    
    printf("Enter amount of numbers which evenly divisible by 4 : \n");
    scanf("%d",&n);


    FILE *myFile;
    myFile = fopen("numbers.txt", "r");

    //read file into array
    numberArray = (int *) malloc(sizeof(int) * n);
    sizeOfGlobalArray = 4;
    threadSize = n/4;
    globalArr = (int*)malloc(sizeof(int) * threadSize);
    // globalArr[sizeOfGlobalArray];

    sem_init(&semaphore, 0, threadSize);
    if (myFile == NULL){
        printf("Error Reading File\n");
        exit (0);
    }

    for (int i = 0; i < n; i++){
        fscanf(myFile, "%d,", &numberArray[i] );
    }

    fclose(myFile);
    
    // for (int i = 0; i < n; i++){
    //     printf("Number is: %d\n\n", numberArray[i]);
    // }
    
    pthread_t threads[threadSize];
    for(curentThread = 0; curentThread < threadSize; curentThread++)
    {
        sem_wait(&semaphore);
        pthread_create(&threads[curentThread],NULL,sumFromArray,(void*)NULL);
        pthread_join(threads[curentThread],NULL);
        sem_post(&semaphore);
        // printf(" c th %d\n" , curentThread);
    }
    
    // for(int i  = 0; i < threadSize; i++)
    // {
    //     sem_wait(&semaphore);
        
    //     sem_post(&semaphore);
    // }
    sem_destroy(&semaphore);
    int totalSum = 0;
    for (int i = 0; i < threadSize;i++)
    {
        totalSum += globalArr[i];
        printf("%d\n",globalArr[i]);
    }
    printf("sum is %d\n",totalSum);
    





    return 0;
}

