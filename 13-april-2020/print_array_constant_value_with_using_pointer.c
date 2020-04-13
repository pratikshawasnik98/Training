#include<stdio.h>
#include<conio.h>
void main()
{

    char *ch[3];
    ch[0]="abc";
    ch[1]="xyz";
    ch[2]="pqr";

    for(int i=0;i<=2;i++)
    {
        printf("%s \n",ch[i]);
    }
    getch();
}
