#include<stdio.h>
#include<conio.h>
void main()
{
    int number,remender=0,even=0,odd=0;

    printf("Enter a number : \n");
    scanf("%d",&number);

    while(number>0)
    {
        remender=number%10;
        number=number/10;

        if(remender%2==0)
        {
            even=even+remender;
        }
        else
        {
            odd=odd+remender;
        }
    }
    printf("Even Number Addition : %d \n",even);
    printf("Odd Number Addition : %d \n",odd);

    getch();
}
