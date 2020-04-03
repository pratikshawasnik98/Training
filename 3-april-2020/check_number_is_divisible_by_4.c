#include<stdio.h>
#include<conio.h>
void main()
{
    int number;

    printf("Enter a number : \n");
    scanf("%d",&number);

    if(number%4==0)
    {
        printf("%d Number is divisible by 4 ",number);
    }
    else
    {
        printf("%d Number is not divisible by 4 ",number);
    }
    getch();
}
