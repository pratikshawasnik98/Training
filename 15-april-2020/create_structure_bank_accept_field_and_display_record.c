#include<stdio.h>
#include<conio.h>
struct bank
{
    int customer_id;
    char customer_name;
    char customer_address;
    char customer_number;
    char customer_accountNumber;
}bank1;
void main()
{
    printf("Enter a customer ID : \n");
    scanf("%d",&bank1.customer_id);

    printf("Enter a customer name : \n");
    scanf("%s",&bank1.customer_name);

    printf("Enter a customer address : \n");
    scanf("%s",&bank1.customer_address);

    printf("Enter a customer number : \n");
    scanf("%s",&bank1.customer_number);

    printf("Enter a customer account number : \n");
    scanf("%s",&bank1.customer_accountNumber);

    printf("Enter a customer ID : %d\n",bank1.customer_id);
    printf("Enter a customer name : %s\n",bank1.customer_name);
    printf("Enter a customer address : %s\n",bank1.customer_address);
    printf("Enter a customer number : %s\n",bank1.customer_number);
    printf("Enter a customer account number : %s\n",bank1.customer_accountNumber);

    getch();

}

