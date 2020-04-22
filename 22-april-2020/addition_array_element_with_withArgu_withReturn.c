#include<stdio.h>
#include<conio.h>
void main()
{
        int c,i;
        int *b[4];

        printf("Enter a element : \n");
        for(i=0;i<=3;i++)
        {
                scanf("%d",&b[i]);
        }
        c=array(&b);
        printf("Result = %d",c);
        getch();
}
int array(int a[4])
{
    int i,sum=0;
    for(i=0;i<=3;i++)
    {
        sum=sum+a[i];
    }
    return sum;
}
