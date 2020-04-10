#include<stdio.h>
#include<conio.h>
void main()
{
    int a[2][2],b[2][2],c[2][2],i;
    printf("Enter a 2*2 1st matrix element : \n");
    for(i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                scanf("%d",&a[i][j]);
        }
    }
    printf("Enter a 2*2 2sd matrix element : \n");
    for(i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                scanf("%d",&b[i][j]);
        }
    }
    printf("addition of 2 matrix element : \n");
    for(i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                c[i][j]=a[i][j]+b[i][j];
        }
    }

    printf("2*2 Matrix addition is :\n");
    for(i=0;i<=1;i++)
    {
        for(int j=0;j<=1;j++)
        {
                printf("%d ",c[i][j]);
        }
        printf("\n");
    }
    getch();
}
