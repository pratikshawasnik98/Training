#include<stdio.h>
#include<conio.h>
void main()
{
    int row,col;
    for(row=1;row<=6;row++)
    {
        for(col=1;col<=row;col++)
        {
            if(col==1)
            {
                printf("A");
            }
            else if(col==2)
            {
                printf("B");
            }
            else if(col==3)
            {
                printf("C");
            }
            else if(col==4)
            {
                printf("D");
            }
            else if(col==5)
            {
                printf("E");
            }
            else if(col==6)
            {
                printf("F");
            }
        }
        printf("\n");
    }
    getch();
}
