#include<stdio.h>
#include<conio.h>
void main()
{
    int a[5],i,num=1,fact=1;
    printf("Enter a five array element : \n");
    for(i=0;i<=4;i++)
    {
        scanf("%d",&a[i]);
    }
    for(i=4;i>=0;i--)
    {
        while(num<=a[i])
        {
            fact=fact*num;
            num++;
        }
    }
    printf("\nFactorial : %d ",fact);
    getch();
}

