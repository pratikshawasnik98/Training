#include<stdio.h>
#include<conio.h>
void main()
{
    int i,j,c=0,l,flag=0;
    char name[10],rev[10];
    printf("Enter a name : \n");
    scanf("%s",&name);

    for(i=0;name[i]='\0';i++)
    {
        c=c+1;
    }
    l=c-1;

    for(j=0;j<=c-1;j++)
    {
        rev[l]=name[j];
        l--;
    }

    for(i=0;i<=c-1;i++)
    {
        if(name[i]!=rev[l])
        {
            flag++;
            //break;
        }
    }

    if(flag>=1)
    {
        printf("Not palendrome \n");
    }
    else
    {
        printf("Palendrome string");
    }
    getch();
}
