#include<stdio.h>
#include<conio.h>
void main()
{
    int number=1;
    do
    {
        if(number%2==0)
        {
            printf("%d Number is even \n",number);
        }
        else
        {
            printf("%d Number is odd \n",number);
        }
        number++;
    }while(number<=20);
    getch();
}

