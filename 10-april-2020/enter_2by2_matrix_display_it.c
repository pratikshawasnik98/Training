#include<stdio.h>
#include<conio.h>
void main()
{
    int a[2][2],i;
    printf("Enter a 2*2 matrix element : \n");
    for(i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                scanf("%d",&a[i][j]);
        }
    }
    printf("2*2 Matrix is :\n");
    for(i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                printf("%d ",a[i][j]);
        }
        printf("\n");
    }
    getch();
}
