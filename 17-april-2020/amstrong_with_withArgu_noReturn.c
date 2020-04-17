#include<stdio.h>
#include<conio.h>
void main()
{
    int number;
    printf("Enter a number : \n");
    scanf("%d",&number);

    amstrong(number);
    getch();
}
void amstrong(int num)
{
    int digit,orginal,temp=0;

    orginal=num;

    while(num!=0)
    {
        digit=num%10;
        temp=digit*digit*digit+temp;
        num=num/10;
    }

    if(orginal==temp)
    {
        printf("Number is amstrong \n");
    }
    else
    {
        printf("Number is not amstrong \n");
    }
}


