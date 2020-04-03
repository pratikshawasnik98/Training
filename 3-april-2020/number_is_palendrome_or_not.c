#include<stdio.h>
#include<conio.h>
void main()
{
    int number,org,temp=0,digit1,digit2;

    printf("Enter a number : \n");
    scanf("%d",&number);

    number=org;
    digit1=number%10;
    number=number/10;
    digit2=number%10;
    number=number/10;

    temp=digit1*100+digit2*10+number*1;

    if(temp=org)
    {
        printf("Number is palendrome %d ",temp);
    }
    else
    {
        printf("Number is not palendrome %d ",temp);
    }
    getch();
}

