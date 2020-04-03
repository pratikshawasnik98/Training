#include<stdio.h>
#include<conio.h>
void main()
{
    int triangle,base,height;

    printf("Enter a base and height : \n");
    scanf("%d %d",&base,&height);

    triangle=base*height;

    printf("area of triangle : %d",triangle);

    getch();
}

