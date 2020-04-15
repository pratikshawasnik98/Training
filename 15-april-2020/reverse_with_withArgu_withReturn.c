#include<stdio.h>
#include<conio.h>
void main()
{
    int number,reverse;
    printf("Enter a number :\n");
    scanf("%d",&number);
    reverse=rev(number);
    printf("Reverse of number : %d\n",reverse);
    getch();
}
int rev(int num)
{
    int rev,digit1,digit2,orginal;
    orginal=num;
    digit1=num%10;
    num=num/10;
    digit2=num%10;
    num=num/10;
    rev=digit1*100+digit2*10+num*1;
    return rev;
}


