#include<stdio.h>
#include<conio.h>
void main()
{
    int radius ,height,cone;

    printf("Enter a radius and height : \n");
    scanf("%d %d",&radius,&height);

    cone=0.333f*3.14f*radius*radius*height;

    printf("area of cone : %d",cone);

    getch();
}

