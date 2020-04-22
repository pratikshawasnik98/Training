#include<stdio.h>
#include<conio.h>
void main()
{
        int c;
        c=array();
        printf("Result = %d",c);
        getch();
}
int array()
{
    int i,sum=0;
    int b[4];

        printf("Enter a element : \n");
        for(i=0;i<=3;i++)
        {
                scanf("%d",&b[i]);
        }
    for(i=0;i<=3;i++)
    {
        sum=sum+b[i];
    }
    return sum;
}

