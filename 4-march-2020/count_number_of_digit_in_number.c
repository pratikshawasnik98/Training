#include<stdio.h>
#include<conio.h>
void main()
{
    int number,count=0;
    printf("Enter  a number \n");
    scanf("%d",&number);

    while(number>0)
    {
        number=number/10;
        count++;
    }
    printf("Total number of Digit is : %d \n",count);
    getch();
}
