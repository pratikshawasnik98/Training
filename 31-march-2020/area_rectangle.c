#include<stdio.h>
#include<conio.h>
void main()
{
    float length,breath,rectangle;
    printf("Enter length and breath\n");
    scanf("%f %f ",&length,&breath);

    rectangle=length*breath;

    printf("area of rectangle : %f ",rectangle);

    getch();
}
