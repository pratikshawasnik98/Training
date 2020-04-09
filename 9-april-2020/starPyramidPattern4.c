#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=1;row<=5;row++)
    {
        for(int sp=4;sp>=row;sp--)
        {
            printf(" ");
        }
        for(col=1;col<=row;col++)
        {
            printf(" *");
        }
        printf("\n");
    }

    getch();
}



