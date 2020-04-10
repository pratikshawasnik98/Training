#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=1;row<=4;row++)
    {
        for(int sp=3;sp>=row;sp--)
        {
            printf(" ");
        }
        for(col=1;col<=row;col++)
        {
            printf("%d",col);
        }
        printf("\n");
    }

    getch();
}

