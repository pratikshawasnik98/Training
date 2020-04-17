#include<stdio.h>
#include<conio.h>
void main()
{
    int number;
    printf("Enter a five number : \n");
    scanf("%d",&number);
    addition(number);
    getch();
}
void addition(int num)
{
    int remender=0,even=0,odd=0;


    while(num!=0)
    {
       remender=num%10;
       num=num/10;
       if(remender%2==0)
        {
            even=even+remender;
        }
        else
        {
            odd=odd+remender;
        }
    }
    printf("Addition of Even number : %d\n",even);
    printf("Addition of odd number : %d\n",odd);

}

