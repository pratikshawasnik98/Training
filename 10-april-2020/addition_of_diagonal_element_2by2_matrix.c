#include<stdio.h>
#include<conio.h>
void main()
{
    int a[3][3],i,c=0;
    printf("Enter a 3*3 matrix element : \n");
    for(i=0;i<=2;i++)
    {
        for(int j=0;j<=2;j++)
        {
                scanf("%d",&a[i][j]);
        }
    }
    printf("3*3 Matrix diagonal element is :\n");
    for(i=0;i<=2;i++)
    {
        for(int j=0;j<=2;j++)
        {
                printf("%d ",a[i][j]);
        }
        printf("\n");
    }
    printf("2*2 Matrix is :\n");
    for(i=0;i<=2;i++)
    {
        for(int j=0;j<=2;j++)
        {
                if(i==j)
                    c=c+a[i][j];

        }
    }
    printf("addition of diagonal element %d ",c);
    getch();
}

