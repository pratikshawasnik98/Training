#include<stdio.h>
#include<conio.h>
void main()
{
    char choice;

    printf("Enter a character : \n");
    fflush(stdin);
    scanf("%c",&choice);

    switch(choice)
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            printf("%c Character is vowel \n",choice);
            break;
        default:
            printf("%c Character is not vowel \n",choice);
            break;
    }
    getch();
}
