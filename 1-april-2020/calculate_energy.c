#include<stdio.h>
#include<conio.h>
void main()
{
    int energy ,mass,velocity;

    printf("Enter a mass and velocity : \n");
    scanf("%d %d",&mass,&velocity);

    energy=0.5f*mass*velocity*velocity;

    printf("energy : %d",energy);

    getch();
}

