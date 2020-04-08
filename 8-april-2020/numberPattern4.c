#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=3;row>=1;row--)
    {
        for(col=3;col>=1;col--)
        {
            printf("%d",row);
        }
        printf("\n");
    }

    getch();
}


