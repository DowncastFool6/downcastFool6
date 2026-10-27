#include <stdio.h>

int main() {
    int counter = 37;
    float sum, term;

    sum = 0;

    while (counter >= 1) {
        term = (float)(counter * (counter + 1)) / (38 - counter);
        sum = sum + term;
        counter--;
    }
    printf("The sum is: %.2f\n", sum);

    return 0;
}