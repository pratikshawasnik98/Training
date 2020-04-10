#include<stdio.h>
#include<conio.h>
void main()
{
    int a[4],i,temp=0,j;
    printf("Enter a 5 array element : \n");
    for(i=0;i<=4;i++)
    {
            scanf("%d",&a[i]);
    }
    for(i=0;i<=4;i++)
    {
        for(j=j+1;j<=4;j++)
        {
            if(a[i]>a[j])
            {
                temp=a[i];
                a[i]=a[j];
                a[j]=temp;
            }
        }
    }
    printf("Sorted element are : \n");
    for(i=0;i<=4;i++)
    {
            printf("%d \n",a[i]);
    }
    getch();
}
