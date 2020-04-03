#include<stdio.h>
#include<conio.h>
void main()
{
    char choice;

    printf("Enter a character : \n");
    fflush(stdin);
    scanf("%c",&choice);

    if(choice=='a' || choice=='e' || choice=='i' || choice=='o' || choice=='u' )
    {
            printf("%c Character is vowel \n",choice);
    }
    else
    {
            printf("%c Character is not vowel \n",choice);
    }
    getch();
}

