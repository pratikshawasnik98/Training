#include<stdio.h>
#include<conio.h>
void main()
{
    int number1,number2;

    printf("Enter a two numbers : \n");
    scanf("%d %d",&number1,&number2);

    number1=number1+number2;
    number2=number1-number2;
    number1=number1-number2;

    printf("Number after Swapping :%d %d ",number1,number2);
    getch();
}
