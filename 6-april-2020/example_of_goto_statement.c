#include<stdio.h>
#include<conio.h>
void main()
{
    int number;
    printf("Enter a number : \n");
    scanf("%d",&number);

    if(number>10)
    {
        goto ten;
    }
    else
    {
        goto less;
    }

    ten:
        printf("Greater than 10 \n");
        goto last;

    less:
        printf("Less than 10 \n");
        goto last;

    last:
        printf("Final Output");

    getch();

}
