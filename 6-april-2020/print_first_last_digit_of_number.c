#include<stdio.h>
#include<conio.h>
void main()
{
    int number,last=0;
    printf("Enter  a number \n");
    scanf("%d",&number);

    last=number%10;
    printf("Last number : %d \n",last);
    while(number>0)
    {
        //number--;
        number=number/10;

    }
    printf("first number of Digit is : %d \n",number);
    getch();
}

