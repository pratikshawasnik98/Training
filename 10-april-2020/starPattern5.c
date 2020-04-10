#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=1;row<=7;row++)
    {
        if(row==2 || row==4 || row==6)
        {
            continue;
        }
        for(int sp=6;sp>=row;sp--)
        {
            printf(" ");
        }
        for(col=1;col<=row;col++)
        {
            printf("* ");
        }
        printf("\n");
    }

    getch();
}


