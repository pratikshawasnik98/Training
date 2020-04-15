#include<stdio.h>
#include<conio.h>
void main()
{
    int c;
    c=swap();
    printf("After swapping number 1 : %d \nnumber 2 :%d",c);
    getch();
}
int swap()
{
    int num1,num2;
    int *a,*b;
    printf("Enter a numbers :\n");
    scanf("%d %d",&num1,&num2);

    num1=num1+num2;
    num2=num1-num2;
    num1=num1-num2;
    a=num1;
    *b=num2;
    return a;
}

