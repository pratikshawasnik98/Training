#include<stdio.h>
#include<conio.h>
void main()
{
    int number,org,temp,digit1,digit2;

    printf("Enter a number : \n");
    scanf("%d",&number);

    number=org;
    digit1=number%10;
    number=number/10;
    digit2=number%10;
    number=number/10;

    temp=number*number*number+digit1*digit1*digit1+digit2*digit2*digit2;

    if(temp=org)
    {
        printf("Number is amstrong ");
    }
    else
    {
        printf("Number is not amstrong  ");
    }
    getch();
}
