#include<stdio.h>
#include<conio.h>
void main()
{
    int result;
    result=amstrong();
    if(result==0)
    {
        printf("Number is amstrong \n");
    }
    else
    {
        printf("Number is not amstrong \n");
    }
    getch();
}
int amstrong()
{
    int num,digit,orginal,temp=0;
    printf("Enter a number : \n");
    scanf("%d",&num);

    orginal=num;

    while(num!=0)
    {
        digit=num%10;
        temp=digit*digit*digit+temp;
        num=num/10;
    }
    if(orginal==temp)
    {
        return 0;
    }
    else
    {
        return 1;
    }

}


