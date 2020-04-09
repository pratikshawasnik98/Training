#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=1;row<=3;row++)
    {
        for(col=1;col<=row;col++)
        {
            if(col==1)
            {
                printf("1");
            }
            else
            {
                    printf("0");
            }
        }
        printf("\n");
    }
    for(row=2;row>=1;row--)
    {
        for(col=1;col<=row;col++)
        {
            if(col==1)
            {
                printf("1");
            }
            else
            {
                printf("0");
            }
        }
        printf("\n");

    }

    getch();
}




