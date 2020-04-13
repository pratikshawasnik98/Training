#include<stdio.h>
#include<conio.h>
void main()
{
    int i;
    char name[10];
    printf("Enter a name: \n ");
    scanf("%s",&name);
    for(i=0;name[i]!='\0';i++)
    {
        if(name[i]>=97 && name[i]<=123)
        {
            name[i]=name[i]-32;
        }
        printf("%c",name[i]);
    }
    getch();
}
