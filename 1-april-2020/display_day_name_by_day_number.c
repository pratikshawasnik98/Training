#include<stdio.h>
#include<conio.h>
void main()
{
    int number;
    printf("Enter a day Number\n");
    scanf("%d",&number);

    switch(number)
    {
        case 0:
            printf("EnterInvalid day number");
            break;

        case 1:
            printf("Mon");
            break;

        case 2:
            printf("Tues");
            break;

        case 3:
            printf("Wed");
            break;

        case 4:
            printf("Thru");
            break;

        case 5:
            printf("Fri");
            break;

        case 6:
            printf("Sat");
            break;

        case 7:
            printf("Sunday");
            break;

    }
    getch();
}

