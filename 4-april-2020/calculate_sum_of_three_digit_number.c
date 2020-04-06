#include<stdio.h>
#include<conio.h>
void main()
{
    int number,digit=0,count=4,sum=0;
    printf("Enter a number : \n");
    scanf("%d",&number);
    while(count>0)
    {
        digit=number%10;
        number=number/10;
        sum=sum+digit;
        count--;
    }
    printf("Print the result : %d  \n",sum);

    getch();
}


