#include <stdio.h>

int main() {
    int a, b;
    
    printf("Enter any range of numbers, smallest number first then largest.\n");
    scanf("%d", &a);
    scanf("%d", &b);

    int sum = 0;
    int counter = a;

    if (b > a) {
        while (counter <= b) {
            if (counter % 2 == 0) {
                sum = sum + (counter * counter * counter);
            }                
            counter = counter + 1;
        }
        printf("The cubic sum of the even numbers is: %d", sum);
    } else {
        printf("Invaild range of numbers. Try again.");
    } 

    return 0;
}