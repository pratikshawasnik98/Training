
#include<stdio.h>
#include<conio.h>
void main()
{
    int number1,number2,temp;

    printf("Enter a two numbers : \n");
    scanf("%d %d",&number1,&number2);

    temp=number1;
    number1=number2;
    number2=temp;

    printf("Number after Swapping :%d %d ",number1,number2);
    getch();
}
