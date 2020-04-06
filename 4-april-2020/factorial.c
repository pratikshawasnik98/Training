#include<stdio.h>
#include<conio.h>
void main()
{
    int number, factorial=1;

    printf("Enter a number : \n");
    scanf("%d",&number);

    while(number>0)
    {
        factorial=factorial*number;
        number--;
    }
    printf("Factorial of number is : %d \n",factorial);
    getch();
}

