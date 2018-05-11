#include <stdio.h>
#include <mpi.h>

int main(int argc, char** argv) {

    MPI_Init(&argc, &argv);

	int rank, size;
	MPI_Comm_rank(MPI_COMM_WORLD, &rank);
	MPI_Comm_size(MPI_COMM_WORLD, &size);

	int number = rank + 1;
    int summ = 0;
    int diff = size / 2;
    int total = 0;
    MPI_Allreduce(&number, &total, 1, MPI_INT, 
    MPI_SUM, MPI_COMM_WORLD);
    if(rank == 0){
	    printf("%d\n", total);
    }
	
	MPI_Finalize();

	return 0;
}