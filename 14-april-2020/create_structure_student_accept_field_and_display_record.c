#include<stdio.h>
#include<conio.h>
struct student
{
    int id;
    char name[10];
    char address[30];
}student1;
void main()
{
    printf("Enter a id : \n");
    scanf("%d",&student1.id);

    printf("Enter a name : \n ");
    scanf("%s",&student1.name);

    printf("Enter a address : \n ");
    scanf("%s",&student1.address);

    printf("ID : %d\n",student1.id);
    printf("Name : %s \n",student1.name);
    printf("Address : %s \n",student1.address);


    getch();
}
