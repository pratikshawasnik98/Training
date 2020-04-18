#include<stdio.h>
#include<conio.h>
void main()
{
    int rows;
    printf("enter a rows : \n");
    scanf("%d",&rows);

    pattern(rows);
    getch();
}
void pattern(int row)
{
    int i,j;
    for(i=1;i<=row;i++)
    {
        for(j=1;j<=i;j++)
        {
            printf("* ");
        }
        printf("\n");
    }
}


