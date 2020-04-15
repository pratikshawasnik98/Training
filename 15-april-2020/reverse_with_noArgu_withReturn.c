#include<stdio.h>
#include<conio.h>
void main()
{
    int a;
    a=rev();
    printf("Reverse of number : %d\n",a);
    getch();
}
int rev()
{
    int num,rev,digit1,digit2,orginal;
    printf("Enter a number :\n");
    scanf("%d",&num);

    orginal=num;
    digit1=num%10;
    num=num/10;
    digit2=num%10;
    num=num/10;

    rev=digit1*100+digit2*10+num*1;

    return rev;
}

