#include<stdio.h>
#include<conio.h>
void main()
{
    int n,count=1;
    do
    {
        printf("Enter a number : \n");
        scanf("%d",&n);
        count++;
    }while(count<=5);
    sum(n);
    getch();
}
void sum(int add)
{
    int count=1;
    do
    {
        add=add+add;
        count++;
    }while(count<=5);
    printf("%d sum ",add);
}
