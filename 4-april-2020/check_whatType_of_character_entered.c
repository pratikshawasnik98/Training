#include<stdio.h>
#include<conio.h>
void main()
{
    char choice,answer='y';
    printf("Enter a number : \n");
    fflush(stdin);
    scanf("%c",&choice);

    do
    {
        if(choice=='a')
        {
            printf("Lower case \n");
        }
        else if(choice=='A')
        {
            printf("Upper case\n");
        }
        else if(choice==1)
        {
            printf("Number\n");
        }
        else
        {
            printf("Special Symbol\n");
        }

        printf("Wheather you want to enter a another character : \n");
        fflush(stdin);
        scanf("%d",&answer);

    }while(answer=='y');

    getch();
}
