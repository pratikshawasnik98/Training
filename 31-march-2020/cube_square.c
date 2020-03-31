#include<stdio.h>
#include<conio.h>
void main()
{
    int number,square,cube;
    printf("Enter a number that you want to square it \n");
    scanf("%d",&number);
    square=number*number;
    printf("Square of a number : %d",square);

    printf("\nEnter a number that you want to cube it \n");
    scanf("%d",&number);
    cube=number*number*number;
    printf("cube of number : %d",cube);

    getch();
}
