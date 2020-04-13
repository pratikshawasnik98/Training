#include<stdio.h>
#include<conio.h>
void main()
{
    int a=2,*pointer;
    pointer=&a;

    printf("%u \n",pointer);
    pointer++;

    printf("%u \n",pointer);

    getch();
}

