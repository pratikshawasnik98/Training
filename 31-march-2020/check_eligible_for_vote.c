#include<stdio.h>
#include<conio.h>
void main()
{
    int age;
    printf("Enter your age:\n");
    scanf("%d",&age);

    if(age>18)
    {
        printf("You are eligible for votting");
    }
    else
    {
        printf("You are not eligible for votting");
    }
    getch();
}
