#include<stdio.h>
#include<conio.h>
void main()
{
    int number;
    printf("Enter a number\n");
    scanf("%d",&number);

    switch(number)
    {
        case 0:
            printf("Zero");
            break;

        case 1:
            printf("One");
            break;

        case 2:
            printf("Two");
            break;

        case 3:
            printf("Three");
            break;

        case 4:
            printf("Four");
            break;

        case 5:
            printf("Five");
            break;

    }
    getch();
}
