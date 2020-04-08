#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=1;row<=4;row++)
    {
        for(col=1;col<=4;col++)
        {
            if(row==2 || row==4)
            {
                printf("A");
            }
            else
            {
                printf("%d",col);
            }
        }
        printf("\n");
    }
    getch();
}

