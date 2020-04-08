#include<stdio.h>
#include<conio.h>
void main()
{
    int number;
    int fact=1;
    printf("Enter a number: \n");
    scanf("%d",&number);

    for(int i=1;i<=number;i++)
    {
        fact=fact*i;
    }
    printf("Factorial of Number is : %d \n",fact);
    getch();
}
