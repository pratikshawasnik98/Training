#include<stdio.h>
#include<conio.h>
void main()
{
    int n,count=1,s;
    do
    {
        printf("Enter a number : \n");
        scanf("%d",&n);
        count++;
    }while(count<=5);
    s=sum(n);
    printf("%d sum ",s);
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
    return add;
}

