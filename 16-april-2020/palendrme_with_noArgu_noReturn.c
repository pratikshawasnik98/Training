#include<stdio.h>
#include<conio.h>
void main()
{
    palendrome();
    getch();
}
void palendrome()
{
    int num,digit,orginal,temp=0;
    printf("Enter a number : \n");
    scanf("%d",&num);

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
