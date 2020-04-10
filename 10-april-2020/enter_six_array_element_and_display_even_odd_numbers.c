#include<stdio.h>
#include<conio.h>
void main()
{
    int a[5],i;
    printf("Enter a six array element : \n");
    for(i=0;i<=4;i++)
    {
        scanf("%d",&a[i]);
    }
    for(i=0;i<=4;i++)
    {
        if(a[i]%2==0)
        {
            printf("\neven = %d ",a[i]);
        }
        else
        {
            printf("\nodd = %d ",a[i]);
        }

    }
    getch();
}
