#include<stdio.h>
#include<conio.h>
void main()
{
    int a=0,b=1,c=0,i=1;
    do
    {
        c=a+b;
        printf("%d\n",c);
        a=b;b=c;i++;
    }while(i<=10);
    getch();
}
