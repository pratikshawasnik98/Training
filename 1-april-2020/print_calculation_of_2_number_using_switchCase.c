
#include<stdio.h>
#include<conio.h>
void main()
{
    int number1,number2;
    int result =0;
    char op;
    printf("Enter a two Numbers\n");
    scanf("%d &d",&number1,&number2);

    printf("Enter a operator :\n");
    fflush(stdin);
    scanf("%c",&op);

    switch(op)
    {
        case '+':
            result=number1+number2;
            printf("Result is : %d",result);
            break;

        case '-':
            result=number1-number2;
            break;

        case '*':
            result=number1*number2;
            break;

        case '/':
            result=number1/number2;
            break;

        case '%':
            result=number1%number2;
            break;
    }
    printf("Result is : %d",result);
    getch();
}

