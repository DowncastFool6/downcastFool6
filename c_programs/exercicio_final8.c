#include <stdio.h>

int main() {
    int counter, sum, is_prime, divisor, a, b;

    printf("Enter a number range. \n");
    scanf("%d", &a);
    scanf("%d", &b);

    counter = a;

    while (counter <= b) {
        is_prime = 1;
        divisor = 2;

        while (divisor < counter) {
            if (counter % divisor == 0){
                is_prime = 0;
            }
            divisor++;
        }
        if (is_prime == 1){
            printf("%d is a prime number.\n", counter);
        }
        counter++;
    }

    return 0;
}