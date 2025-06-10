#include <stdio.h>
main(){
	printf("Zadacha: Program za obrabotka na masiva A[N,N], kudeto dannite sa celi chisla v intervala [-1000;1000].\n");
    printf("Programata izvurshva slednite deistviq:\n");
    printf("a) Nulirane na elementite v masiva A, za koito sumata sus sutvetniya element ot masiva B e chetno chislo, prinadlejashto na zadaden interval [K - L].\n");
    printf("b) Opredelqne na broq na promenenite elementi v masiva A.\n");
    printf("Avtor na programata: Vladislava Stefanova Korcheva\n Fakultet: FIT\n Specialnost: DIT\n Fakulteten nomer: 081224004\n");
    printf("\n");
    printf("\n");
    printf("Reshenie\n");
    
    int N, K, L, changeCount = 0;
   
    printf("Vvedete razmera na masiva N (N x N): ");
    scanf("%d", &N);

    int A[N][N], B[N][N];
      for(int i=0; i<N;i++)
   {        
        for(int j=0;j<N;j++)
        {      printf("Enter for A[%d][%d]=",i,j);
           scanf("%d",&A[i][j]);
               
               while(A[i][j]<-1000||A[i][j]>1000)
               {      printf("Enter for A[%d][%d]=",i,j);
           scanf("%d",&A[i][j]); 
           
           }
              
       }
   }
    printf("\nmass A:\n"); 
    for(int i=0; i<N;i++)
   {
        for(int j=0;j<N;j++)
        {
               
              printf("%d\t",A[i][j]);
        }
         printf("\n");
    }
     for(int i=0; i<N;i++)
   {        
        for(int j=0;j<N;j++)
        {     
                         
           printf("Enter for B[%d][%d]=",i,j);
              scanf("%d",&B[i][j]);
              while(B[i][j]<-1000||B[i][j]>1000)
               {      printf("Enter for B[%d][%d]=",i,j);
           scanf("%d",&B[i][j]);    
           
           }
       }
   }
    printf("\nmass B:\n"); 
    for(int i=0; i<N;i++)
   {
        for(int j=0;j<N;j++)
        {
               
              printf("%d\t",B[i][j]);
        }
         printf("\n");
    }
    printf("Enter K: ");
    scanf("%d", &K);
    printf("Enter L: ");
    scanf("%d", &L);
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            int sum = A[i][j] + B[i][j];
            if (sum % 2 == 0 && sum >= K && sum <= L) {
                A[i][j] = 0;  
                changeCount++; 
            }
        }
    }
    printf("Changes make in matrix A: %d",changeCount);
    printf("\nmass A after the changes:\n"); 
    for(int i=0; i<N;i++)
   {
        for(int j=0;j<N;j++)
        {
               
              printf("%d\t",A[i][j]);
        }
         printf("\n");
    }
    
    
    
}
