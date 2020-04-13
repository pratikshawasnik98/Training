#include<stdio.h>
#include<conio.h>
void main()
{
    int a=2,*pointer;
    pointer=&a;

    printf("%d \n",a);
    *pointer=24;

    printf("%d \n",a);
    getch();
}
