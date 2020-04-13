#include<stdio.h>
#include<conio.h>
void main()
{
    int a[5]={4,3,5,6,8};
    int *pointer;
    pointer=&a[0];

    for(int i=1;i<=5;i++)
    {
        printf("%d \n",*pointer);
        pointer++;
    }
    getch();
}
