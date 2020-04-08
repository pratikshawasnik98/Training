#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=1;row<=3;row++)
    {
        for(col=3;col>=1;col--)
        {
            printf("%d",row);
        }
        printf("\n");
    }

    getch();
}



