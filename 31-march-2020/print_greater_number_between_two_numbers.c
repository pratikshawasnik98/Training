#include<stdio.h>
#include<conio.h>
void main()
{
    int number1,number2;
    printf("Enter a two numbers :\n");
    scanf("%d %d",&number1,&number2);

    if(number1>number2)
    {
        printf("Number is greater %d",number1);
    }
    else
    {
        printf("Number is greater %d",number2);
    }
    getch();
}
