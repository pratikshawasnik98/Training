#include<stdio.h>
#include<conio.h>
void main()
{
    int force ,mass,accleration;

    printf("Enter a mass and accleration : \n");
    scanf("%d %d",&mass,&accleration);

    force=mass*accleration;

    printf("Force : %d",force);

    getch();
}
