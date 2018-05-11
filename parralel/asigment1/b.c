#include <stdio.h>

/* We'll be using MPI routines, definitions, etc. */
#include "mpi.h"

double dotProduct(double *a, double *b, int n) {
  int i;
  double prod = 0.0;
  for (i = 0; i < n; i++) {
    prod += a[i]*b[i];
  }
  return prod;
}
int main(int argc, char** argv) {
    int my_rank;
    int p;
    double prod;
    const int root=0;
    int number = 3,a[3],b[3],i=0,j = 0,n = 3,loc_n;
    int scalar;
    //Number of scanfs
    // a[0] = 1;
    // a[1] = 2;
    // a[2] = 3;
    // b[0] = 4;
    // b[1] = 5;
    // b[2] = 6;
    /* Let the system do what it needs to start up MPI */
    MPI_Init(&argc, &argv);

    /* Get my process rank */
    MPI_Comm_rank(MPI_COMM_WORLD, &my_rank);

    /* Find out how many processes are being used */
    MPI_Comm_size(MPI_COMM_WORLD, &p);

    if (my_rank == 0)
    {
        printf("Enter x , y, z of a vector \n");
        while(i<number)
        {
            scanf("%d",&a[i]);
            i++;
        }
        printf("Enter x , y, z of b vector\n");
        while(j<number)
        {
            scanf("%d",&b[j]);
            j++;
        }
        printf("Enter a scalar \n");
        scanf("%d" ,&scalar);

        // MPI_Scatter(&a,3,MPI_INT,&a,3,MPI_INT,my_rank,MPI_COMM_WORLD);
        // MPI_Scatter(&b,3,MPI_INT,&b,3,MPI_INT,my_rank,MPI_COMM_WORLD);

    }
    MPI_Bcast(&a, 3, MPI_INT, root, MPI_COMM_WORLD);
    MPI_Bcast(&b, 3, MPI_INT, root, MPI_COMM_WORLD);
    // else{
    loc_n = n/p;
    double local_a[loc_n];
    double local_b[loc_n];
    for(i = 0; i < loc_n; i++) {
        local_a[i] = scalar * a[i + my_rank * loc_n];
        local_b[i] = scalar * b[i + my_rank * loc_n];
    }
    double local_prod;
    local_prod = dotProduct(local_a,local_b,loc_n);
    //printf("%f \n",local_prod);
    MPI_Reduce(&local_prod, &prod, 1, MPI_DOUBLE, MPI_SUM, 0, MPI_COMM_WORLD);
    //MPI_Reduce_scatter(&local_prod, &prod, &root, MPI_DOUBLE, MPI_SUM, MPI_COMM_WORLD);
    // float global_sum;
    // MPI_Allreduce(&local_prod, &prod, 1, MPI_FLOAT, MPI_SUM,
    //       MPI_COMM_WORLD);
    // }
    if (my_rank == 0) {
        printf("dotProduct = %f\n", prod);
    }  
    MPI_Finalize();
    return 0;

} /*  main  */
