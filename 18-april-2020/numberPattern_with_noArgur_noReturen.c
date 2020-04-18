
#include<stdio.h>
#include<conio.h>
void main()
{
    pattern();
    getch();
}
void pattern()
{
    int i,j,rows;

    printf("enter a rows : \n");
    scanf("%d",&rows);

    for(i=1;i<=rows;i++)
    {
        for(j=1;j<=i;j++)
        {
            printf("%d ", j);
        }
        printf("\n");
    }
}
