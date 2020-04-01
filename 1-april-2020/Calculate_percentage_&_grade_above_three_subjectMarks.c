#include<stdio.h>
#include<conio.h>
void main()
{
    int subject1,subject2,subject3,total;
    float percentage;

    printf("Enter the three subject marks:\n");
    scanf("%d %d %d",&subject1,&subject2,&subject3);

    total=subject1+subject2+subject3;
    printf("Total of Marks : %d \n",total);

    percentage=total/300.0f*100.0f;

    printf("Percentage :%f \n",percentage);
    printf("Grade :");
    if(percentage>=75)
    {
        printf("Destination");
    }
    else if(percentage<75 && percentage>=60)
    {
        printf("First Class");
    }
    else if(percentage<60 && percentage>=40)
    {
        printf("Secound Class");
    }
    else
    {
        printf("Fail");
    }
    getch();
}
