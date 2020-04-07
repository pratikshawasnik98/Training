#include<stdio.h>
#include<conio.h>
void main()
{
    int number,sum=0,count=1;
    while(count<=5)
    {
        printf("Enter a number : \n");
        scanf("%d",&number);

        sum=sum+number;
        count++;
    }
    printf("Print the result : %d  \n",sum);

    getch();
}

