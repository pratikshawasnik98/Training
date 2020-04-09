#include<stdio.h>
#include<conio.h>
void main()
{
    int a[5],i,add=0;
    printf("Enter a five array element : \n");
    for(i=0;i<=4;i++)
    {
        scanf("%d",&a[i]);
    }
    for(i=4;i>=0;i--)
    {
        add=add+a[i];
    }
    printf("\nAddition : %d",add);
    getch();
}


