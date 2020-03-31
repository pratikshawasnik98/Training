#include<stdio.h>
#include<conio.h>
void main()
{
    int number1,number2,number3;
    printf("Enter a three numbers :\n");
    scanf("%d %d %d",&number1,&number2,&number3);

    if(number1>number2 && number1>number3)
    {
        printf("Number is greater %d",number1);
    }
    else if(number2>number1 && number2>number3)
    {
        printf("Number is greater %d",number2);
    }
    else if(number3>number1 && number3>number2)
    {
        printf("Number is greater %d",number3);
    }
    getch();
}
