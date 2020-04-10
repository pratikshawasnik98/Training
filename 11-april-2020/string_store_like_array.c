#include<stdio.h>
#include<conio.h>
void main()
{
    char name[20];
    printf("Enter a you name:\n");
    scanf("%s",&name);

    for(int i=0;name[i]!='\0';i++)
    {
            printf("Characters : %c\n",name[i]);
    }

    getch();
}

