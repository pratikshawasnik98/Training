#include<stdio.h>
#include<conio.h>
void main()
{
    char name[20];
    int count=0;
    printf("Enter a you name:\n");
    scanf("%s",&name);

    for(int i=0;name[i]!='\0';i++)
    {
           count++;
    }
    for(int j=count;j>=0;j--)
    {
            printf("%c ",name[j]);
    }

    getch();
}


