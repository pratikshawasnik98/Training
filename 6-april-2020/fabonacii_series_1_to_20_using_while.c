#include<stdio.h>
#include<conio.h>
void main()
{
    int a=0,b=1,c=0,i=1;
    while(i<=10)
    {
        c=a+b;
        printf("%d\n",c);
        a=b;b=c;i++;
    }
    getch();
}
