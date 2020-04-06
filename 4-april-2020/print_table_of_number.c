#include<stdio.h>
#include<conio.h>
void main()
{
    int number, res=0,i=1;

    printf("Enter a number : \n");
    scanf("%d",&number);

    while(i<=10)
    {
        res=number*i;
        printf("\n %d * %d = %d ",number,i,res);
        i++;
    }

    getch();
}


