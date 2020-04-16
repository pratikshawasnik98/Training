#include<stdio.h>
#include<conio.h>
void main()
{
    int number;
    printf("Enter a number : \n");
    scanf("%d",&number);

    palendrome(number);
    getch();
}
void palendrome(int num)
{
    int digit,orginal,temp=0;

    orginal=num;

    while(num!=0)
    {
        digit=num%10;
        temp=temp*10+digit;
        num=num/10;
    }

    if(orginal==temp)
    {
        printf("Number is palendrome \n");
    }
    else
    {
        printf("Number is not palendrome \n");
    }
}

