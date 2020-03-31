#include<stdio.h>
#include<conio.h>
void main()
{
    float area,cirum,radius;
    printf("Enter radius\n");
    scanf("%f",&radius);

    area=3.14f*radius*radius;
    printf("area of circle : %f ",area);

    cirum=3.14f*radius*2;

    printf("\ncirumfarence of circle : %f ",cirum);

    getch();
}

