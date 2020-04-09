#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=1;row<=5;row++)
    {
        for(col=1;col<=row;col++)
        {
            if(col==1)
            {
                printf("2");
            }
            else
            {
                printf("1");
            }
        }
        printf("\n");
    }
    getch();
}
