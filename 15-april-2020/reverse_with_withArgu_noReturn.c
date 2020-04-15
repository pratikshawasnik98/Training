#include<stdio.h>
#include<conio.h>
void main()
{
    int number;
    printf("Enter a number :\n");
    scanf("%d",&number);
    rev(number);
    getch();
}
void rev(int num)
{
    int rev,digit1,digit2,orginal;
    orginal=num;
    digit1=num%10;
    num=num/10;
    digit2=num%10;
    num=num/10;
    rev=digit1*100+digit2*10+num*1;
    printf("Reverse of number : %d\n",rev);
}


