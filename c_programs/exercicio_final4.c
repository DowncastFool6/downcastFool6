#include <stdio.h>

int main() {
    int age, sum, counter, maxAge, minAge;
    float average;

    sum = 0;
    counter = 0;

    printf("Type in as many ages as you want to determine the average, oldest and youngest age. Type 0 to stop.\n");

    scanf("%d", &age);

    while (age != 0) {
        if (counter == 0) {
            maxAge = age;
            minAge = age;
        } else {
            if (age > maxAge)
                maxAge = age;
            if (age < minAge)
                minAge = age;
        }
        sum = sum + age;
        counter = counter + 1;

        scanf("%d", &age);
    }

    if (counter > 0) {
        average = (float)sum / counter;
        printf("The average age is: %.2f.\n", average);
        printf("The oldest age is: %d.\n", maxAge);
        printf("The youngest age is: %d.\n", minAge);
    } else {
        printf("No ages were entered. Try again.\n");
    }

    return 0;
}