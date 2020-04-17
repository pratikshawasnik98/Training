#include<stdio.h>
#include<conio.h>
void main()
{
    int result,number;
    printf("Enter a five number : \n");
    scanf("%d",&number);
    result=addition(number);
    printf("Addition of Even number : %d\n",result);
    getch();
}
int addition(int num)
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

    printf("Addition of odd number : %d\n",odd);
    return even;
}


