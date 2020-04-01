#include<stdio.h>
#include<conio.h>
void main()
{
    int salary;

    printf("Enter a salary :\n");
    scanf("%d",&salary);

    if(salary>=20000)
    {
        printf("bonus is 10,000");
    }
    else if(salary>1000 && salary<20000)
    {
        printf("bonus is 10,000");
    }
    else
    {
        printf("bonus is 2000");
    }
    getch();
}
