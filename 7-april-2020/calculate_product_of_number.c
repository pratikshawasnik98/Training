#include<stdio.h>
#include<conio.h>
void main()
{
    int number,n,multi=1;
    printf("Enter a number : \n");
    scanf("%d",&number);

    while(number>0)
    {
        n=number%10;
        number=number/10;

        multi=multi*n;

    }
    printf("Multiplication or Product : %d \n",multi);
    getch();
}
