#include <stdio.h>

int main() {
    int years = 0;
    float anaHeight = 150;
    float anaGrowth = 2;
    float felisHeight = 110;
    float felisGrowth = 3;

    while (felisHeight <= anaHeight) {
        anaHeight = anaHeight + anaGrowth;
        felisHeight = felisHeight + felisGrowth;
        years++;
    }
    printf("It will take %d for Felisberto to be taller than Anacleto.\n", years);

    return 0;
}