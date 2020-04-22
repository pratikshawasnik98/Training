
#include<stdio.h>
#include<conio.h>
void main()
{
    array();
    getch();
}
void array()
{
    int *b[4];
    int i;

    printf("Enter a array element : \n");
    for(i=0;i<=3;i++)
    {
            scanf("%d",&b[i]);
    }
    for(i=3;i>=0;i--)
    {
        printf("%d ",b[i]);
    }

}
