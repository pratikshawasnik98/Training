#include<stdio.h>
#include<conio.h>

void myfun(int x , int y)
{
    int addition;
    addition= x + y ;
    printf("Addition :%d \n ",addition);
}
void main()
{
    int a=2,b=2;
    myfun(a,b);
    getch();
}


