#include<stdio.h>
#include<conio.h>
void main()
{
    int number=0;
    while(number<=10)
    {
        if(number==4)
        {
            continue;
        }
        printf("Number = %d \n",number);
        number++;
    }
    getch();

}

