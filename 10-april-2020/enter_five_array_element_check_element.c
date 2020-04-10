#include<stdio.h>
#include<conio.h>
void main()
{
    int a[5],num,i;
    printf("Enter a five array element : \n");
    for(i=0;i<=4;i++)
    {
        scanf("%d",&a[i]);
    }
    printf("Enter a searching Number : \n");
    scanf("%d",&num);
    for(i=0;i<=4;i++)
    {
        if(num==a[i])
        {
            printf("Number Found %d",num);
        }
    }
        if(num!=a[i])
        printf("Number not Found %d",num);


    getch();
}
