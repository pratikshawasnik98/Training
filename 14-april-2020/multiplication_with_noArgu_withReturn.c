#include<stdio.h>
#include<conio.h>
void main()
{
    int multiplication;

    multiplication = myfun();
    printf("multiplication : %d \n",multiplication);
    getch();
}
void myfun()
{
    int x=4,y=2;
    int multi;
    multi= x * y ;
    return multi;
}

