#include<stdio.h>
#include<conio.h>
void main()
{
    int number, rev=0,digit=0;

    printf("Enter a number : \n");
    scanf("%d",&number);

    while(number>0)
    {
        digit=number%10;
        number=number/10;
        rev=rev*10+digit;
    }
    printf("Reverse of number is : %d \n",rev);
    getch();
}


