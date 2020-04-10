#include<stdio.h>
#include<conio.h>
void main()
{
    int a[5],i,greater,smallest;
    printf("Enter a five array element : \n");
    for(i=0;i<=4;i++)
    {
        scanf("%d",&a[i]);
    }
    for(i=0;i<=4;i++)
    {
        if(greater<a[i])
        {
            greater=a[i];
        }
    }
    for(i=0;i<=4;i++)
    {
        if(smallest>a[i])
        {
            smallest=a[i];
        }
    }
    printf("\nGreatest Number : %d ",greater);
     printf("\nGreatest Number : %d ",smallest);
    getch();
}

