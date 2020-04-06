#include<stdio.h>
#include<conio.h>
void main()
{
    int number=1;
    while(number<=10)
    {
        if(number%5==0)
        {
            break;
        }
        printf("Number = %d \n",number);
        number++;
    }
    getch();

}
