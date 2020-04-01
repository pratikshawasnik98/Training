
#include<stdio.h>
#include<conio.h>
void main()
{
    int number,digit1,digit2,reverse;

    printf("Enter a number :\n");
    scanf("%d",&number);

    digit1=number%10;
    number=number/10;
    digit2=number%10;
    number=number/10;

    reverse=digit1*100+digit2*10+number*1;

    printf("Reverse of number is : %d",reverse);

    getch();
}
