#include<stdio.h>
#include<conio.h>
void main()
{
    int *b[4];
    int i;

    printf("Enter a array element : \n");
    for(i=0;i<=3;i++)
    {
            scanf("%d",&b[i]);
    }
    array(&b);
    getch();
}
int array(int a[4])
{
    int i;
    for(i=3;i>=0;i--)
    {
        printf("%d ",a[i]);
    }
    return a;
}
