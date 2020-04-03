#include<stdio.h>
#include<conio.h>
void main()
{
    int salary,total=0,bonus=0;
    char designation;

    printf("Enter your salary : \n");
    scanf("%d",&salary);

    printf("Enter your desigantion (manager = m , clerk = c peune = p): \n");
    fflush(stdin);
    scanf("%c",&designation);

    switch(designation)
    {
        case 'm':
            bonus=10000;
            break;
        case 'c':
            bonus=5000;
            break;
        case 'p':
            bonus=2000;
            break;
        default:
            printf("Enter a wrong designation ");
            break;
    }
    total=salary+bonus;
    printf("Total salary : %d \n",total);
    getch();
}
