#include <stdio.h>

int main() {
    int age, contributed_years, profession_type;
    int years_rule_a, years_rule_b;
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
        }
        else if (age > 50 && contributed_years >= 40) {
            printf("You can retire.\n");
        }
        else {
            int age_gap_a = 56 - age;
            int career_gap_a = 30 - contributed_years;
            if (age_gap_a < 0) age_gap_a = 0;
            if (career_gap_a < 0) career_gap_a = 0;
            years_rule_a = age_gap_a;
            if (career_gap_a > years_rule_a) years_rule_a = career_gap_a;

            int age_gap_b = 51 - age;
            int career_gap_b = 40 - contributed_years;
            if (age_gap_b < 0) age_gap_b = 0;
            if (career_gap_b < 0) career_gap_b = 0;
            years_rule_b = age_gap_b;
            if (career_gap_b > years_rule_b) years_rule_b = career_gap_b;

            if (years_rule_a <= years_rule_b) {
                penalty = years_rule_a * 0.06;
                printf("Penalized early retirement of %2.f%%.\n", penalty * 100);
            } else {
                penalty = years_rule_b * 0.06;
                printf("Penalized early retirement of %2.f%%.\n", penalty * 100);
            }
        }
    } else {
        if (age > 66) {
            printf("You can retire.\n");
        } else if (age > 60 && contributed_years > 40) {
            printf("You can retire.\n");
        } else {
            int age_gap_1 = 67 - age;
            if (age_gap_1 < 0) age_gap_1 = 0;
            years_rule_a = age_gap_1;

            int age_gap_2 = 61 - age;
            int career_gap_2 = 40 - contributed_years;
            if (age_gap_2 < 0) age_gap_2 = 0;
            if (career_gap_2 < 0) career_gap_2 = 0;
            years_rule_b = age_gap_2;
            if (career_gap_2 > years_rule_b) years_rule_b = career_gap_2;

            if (years_rule_a <= years_rule_b) {
                penalty = years_rule_a * 0.06;
                printf("Penalized early retirement of %2.f%%.\n", penalty * 100);
            } else {
                penalty = years_rule_b * 0.06;
                printf("Penalized early retirement of %2.f%%.\n", penalty * 100);
            }
        }
    }

    return 0;
}