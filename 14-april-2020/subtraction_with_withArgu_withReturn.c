#include<stdio.h>
#include<conio.h>
void main()
{
    int a=8,b=2,subtraction;

    subtraction=myfun(a,b);
    printf("Subtraction : %d \n",subtraction);
    getch();
}
void myfun(int x , int y)
{
    int sub;
    sub= x - y ;
    return sub;
}


