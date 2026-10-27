#include <stdio.h>

int main() {
    int age, contributed_years, profession_type, min_age, min_contribution;
    float penalty;

    printf("How old are you? ");
    scanf("%d", &age);

    printf("How many years have you contributed to your career? ");
    scanf("%d", &contributed_years);

    printf("What is your type of profession, Type 0 for normal or 1 for Rapid wear: ");
    scanf("%d", &profession_type);

    if (profession_type == 1) {
        if (age > 55 && contributed_years >= 30) {
            printf("You can retire.\n");
        } else if (age > 50 && contributed_years >= 40) {
            printf("You can retire.\n");
        } else {
            if (min_age < min_contribution) {
                min_age = 51 - age;
                penalty = min_age * 0.06;
                printf("Penalized early retirement of %2.f year(s).\n", penalty);
            } else if (min_age > min_contribution) {
                min_contribution = 30 - contributed_years;
                penalty = min_contribution * 0.06;
                printf("Penalized early retirement of %2.f year(s).\n", penalty);
            }           
        }

    } else {
        if (age > 66) {
            printf("You can retire.\n");
        } else if (age > 60 && contributed_years > 40) {
            printf("You can retire.\n");
        } else {
            if (min_age < min_contribution) {
                min_age = 61 - age;
                penalty = min_age * 0.06;
                printf("Penalized early retirement of %2.f year(s).\n", penalty);
            } else if (min_age > min_contribution) {
                min_contribution = 40 - contributed_years;
                penalty = min_contribution * 0.06;
                printf("Penalized early retirement of %2.f year(s).\n", penalty);
            }
        }
    }

    return 0;
}