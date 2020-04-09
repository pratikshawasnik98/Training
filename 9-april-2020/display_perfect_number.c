#include<stdio.h>
#include<conio.h>
void main()
{
    int i,num,f=0,r;
    printf("Enter a element : \n");
    scanf("%d",&num);

    for(i=1;i<num;i++)
    {
        if(num%i==0)
        {
            f=f+i;
        }
    }
    if(num==f)
    {
        printf("Perfect Number");
    }
    else
    {
        printf("Perfect Number");
    }
    getch();
}
