#include<stdio.h>
#include<conio.h>
void main()
{
    int a[5],i,even=0,odd=0;
    printf("Enter a six array element : \n");
    for(i=0;i<=4;i++)
    {
        scanf("%d",&a[i]);
    }
    for(i=0;i<=4;i++)
    {
        if(a[i]%2==0)
        {
            even=even+1;
        }
        else
        {
           odd=odd+1;
        }

    }
    printf("\neven = %d ",even);
     printf("\nodd = %d ",odd);
    getch();
}

