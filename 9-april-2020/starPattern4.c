#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=1;row<=4;row++)
    {
        for(col=1;col<=row;col++)
        {
            printf("*");
        }
        printf("\n");
    }
    for(row=3;row>=1;row--)
    {
        for(col=1;col<=row;col++)
        {
            printf("*");
        }
        printf("\n");

    }

    getch();
}




