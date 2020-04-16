#include<stdio.h>
#include<conio.h>
void main()
{
    int result;
    result=multiplication();
    printf("Multiplication of numbers : %d\n",result);

    getch();
}
int multiplication()
{
    int num,multi=1,count=1;
    printf("Enter a five numbers  \n");
    do
    {
    printf("Enter a number : \n");
    scanf("%d",&num);

    multi=multi*num;
    count++;

    }while(count<=5);
    return multi;


}


