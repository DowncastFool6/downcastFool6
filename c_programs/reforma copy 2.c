#include <stdio.h>

int main() {
    
    int professional_type, age, career_years, rule1, rule2;
    float penalty;

    printf("How old are you? ");
    scanf("%d", &age);

    printf("How many years have you contributed to your career? ");
    scanf("%d", &career_years);

    printf("What is your type of profession, Type 0 for normal or 1 for Rapid wear: ");
    scanf("%d", &professional_type);

    if (professional_type == 1) {
        if (age > 55 && career_years > 30) {
            printf("You can retire.\n");
        } else if (age > 50 && career_years > 40) {
            printf("You can retire.\n");
        } else {
            int age_gap_a = 56 - age;
            int career_gap_a = 30 - career_years;
            if (age_gap_a < 0) age_gap_a = 0;
            if (career_gap_a < 0) career_gap_a = 0;
            rule1 = age_gap_a;
            if (career_gap_a > rule1) rule1 = career_gap_a;

            int age_gap_b = 51 - age;
            int career_gap_b = 40 - career_years;
            if (age_gap_b < 0) age_gap_b = 0;
            if (career_gap_b < 0) career_gap_b = 0;
            rule2 = age_gap_b;
            if (career_gap_b > rule2) rule2 = career_gap_b;

            if (rule1 <= rule2) {
                penalty = rule1 * 0.06;
                printf("Penalized early retirement of %2.f%% years.\n", penalty);
            } else {
                penalty = rule2 * 0.06;
                printf("Penalized early retirement of %2.f%% years.\n", penalty);
            }
        }
    }
    
    if (professional_type == 0) {
        if (age > 66) {
            printf("You can retire.\n");
        } else if (age > 60 && career_years > 40) {
            printf("You can retire.\n");
        }
        else {
           int age_gap_1 = 67 - age;
            if (age_gap_1 < 0) age_gap_1 = 0;
            rule1 = age_gap_1;

            int age_gap_2 = 61 - age;
            int career_gap_2 = 40 - career_years;
            if (age_gap_2 < 0) age_gap_2 = 0;
            if (career_gap_2 < 0) career_gap_2 = 0;
            rule2 = age_gap_2;
            if (career_gap_2 > rule2) rule2 = career_gap_2;

            if (rule1 <= rule2) {
                penalty = rule1 * 0.06;
                printf("Penalized early retirement of %2.f%% years.\n", penalty);
            } else {
                penalty = rule2 * 0.06;
                printf("Penalized early retirement of %2.f%% years.\n", penalty);
            }  
        }
    }

    return 0;
}