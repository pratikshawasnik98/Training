#include<stdio.h>
#include<conio.h>
void main()
{
    int a[2][2]={{1,2},{5,6}};
    int b[2][2]={{7,8},{4,5}},c[2][2];
    printf("Addition of two matrix: \n");
       printf("addition of 2 matrix element : \n");
    for(int i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                c[i][j]=a[i][j]+b[i][j];
        }
    }
   printf("2*2 Matrix addition is :\n");
    for(int i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                printf("%d ",c[i][j]);
        }
        printf("\n");
    }
    getch();
}
