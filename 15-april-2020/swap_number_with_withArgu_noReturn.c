#include<stdio.h>
#include<conio.h>
void main()
{
    int num1,num2;
    printf("Enter a numbers :\n");
    scanf("%d %d",&num1,&num2);
    swap(num1,num2);
    getch();
}
void swap(int a,int b)
{
    printf("before swapping number 1: %d \nnumber 2:%d\n",a,b);
    a=a+b;
    b=a-b;
    a=a-b;
    printf("after swapping number 1: %d \nnumber 2:%d\n",a,b);
}

