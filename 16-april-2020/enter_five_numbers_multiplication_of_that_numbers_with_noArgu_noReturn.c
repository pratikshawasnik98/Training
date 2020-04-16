#include<stdio.h>
#include<conio.h>
void main()
{
    multiplication();
    getch();
}
void multiplication()
{
    int num,multi=1,count=1;
    do
    {
    printf("Enter a number : \n");
    scanf("%d",&num);

    multi=multi*num;
    count++;

    }while(count<=5);

    printf("Multiplication of numbers : %d\n",multi);


}

