#include<stdio.h>
#include<conio.h>
void main()
{
    int number,rev=0,rem,temp;
    printf("Enter a number : \n");
    scanf("%d",&number);

    temp=number;
    while(temp>0)
    {
        rem=temp%10;
        rev=rev*10+rem;
        temp=temp/10;
    }
    printf("Reverse of number : %d \n",rev);

    if(number==rev)
    {
        printf("The Number is palendrome : %d\n ",number);
    }
    else
    {
        printf("The Number Not is palendrome : %d\n ",number);
    }
    getch();
}
