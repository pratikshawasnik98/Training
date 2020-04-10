#include<stdio.h>
#include<conio.h>
void main()
{
    int a[2][2],b[2][2],i;
    printf("Enter a 2*2 matrix element : \n");
    for(i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                scanf("%d",&a[i][j]);
        }
    }
    printf("Transpose of matrix element : \n");
    for(i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                b[i][j]=a[i][j];
        }
    }
    for(i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                printf("%d ",b[i][j]);
        }
        printf("\n");
    }
 getch();
}
