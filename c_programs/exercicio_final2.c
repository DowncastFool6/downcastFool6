#include <stdio.h>

int main()
{
    float mark1, mark2, mark3, average;

    printf("Introduce three marks of a student to calculate the average:\n");
    scanf("%f", &mark1);
    scanf("%f", &mark2);
    scanf("%f", &mark3);

    average = (mark1 + mark2 + mark3) / 3;

    if (average == 10)
        printf("Passed with distinction\n");
    else if (average >= 7)
        printf("Passed\n");
    else
        printf("Failed\n");

    return 0;
}