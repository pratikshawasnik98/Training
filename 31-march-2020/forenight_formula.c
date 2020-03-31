#include<stdio.h>
#include<conio.h>
void main()
{
    //forenight formula
    float tempreture,c;
    printf("Enter a tempreture: ");
    scanf("%f",&tempreture);

    c=(5.0f/9.0f)*(tempreture-32);
    printf("calculating tempreture : %f",c);



    getch();
}
