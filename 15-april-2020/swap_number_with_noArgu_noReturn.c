#include<stdio.h>
#include<conio.h>
void main()
{
    swap();
    getch();
}
void swap()
{
    int num1,num2;
    printf("Enter a numbers :\n");
    scanf("%d %d",&num1,&num2);

    num1=num1+num2;
    num2=num1-num2;
    num1=num1-num2;

    printf("swap \nnumber 1 :%d \nnumber 2 :%d",num1,num2);
}
