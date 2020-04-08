#include<stdio.h>
#include<conio.h>
void main()
{
    int number;
    for(number=1;number<=10;number++)
    {
        if(number%2==0)
        {
                printf("Number is even: %d \n",number);
        }
        else
        {
                printf("Number is odd: %d \n",number);
        }
    }
    getch();
}

