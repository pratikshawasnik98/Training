#include<stdio.h>
#include<conio.h>
void main()
{
    int i=1,number,largest,smallest;
    printf("Enter a 10 number : \n");
    printf("Enter a 1st number : \n");
    scanf("%d",&number);

    largest=number;
    smallest=number;

    while(i<10)
    {
        printf("Enter another number : \n ");
        scanf("%d",&number);

        if(number>largest)
        {
            largest=number;
        }
        else if (number<smallest)
        {
            smallest=number;
        }
        i++;
    }
    printf("Largest  Number is : %d\n",largest);
    printf("smallest  Number is : %d\n",smallest);
    getch();
}
