#include <stdio.h>

int main() {
    int num_voters, candidate, candidate1, candidate2, candidate3, counter;

    printf("How many voters are voting? ");
    scanf("%d", &num_voters);

    counter = 0;
    candidate1 = 0;
    candidate2 = 0;
    candidate3 = 0;

    if (num_voters > 0) {
        while (counter < num_voters) {
            printf("Enter the number of the candidate (1, 2 or 3): ");
            scanf("%d", &candidate);
            
            if (candidate == 1) {
                candidate1 = candidate1++;
            }
            if (candidate == 2) {
                candidate2 = candidate2++;
            }
            if (candidate == 3) {
                candidate3 = candidate3++;
            }
        counter = counter++;
        }
        printf("With %d voters.\n", num_voters);
        printf("Candidate 1 received %d votes.\n", candidate1);
        printf("Candidate 2 received %d votes.\n", candidate2);
        printf("Candidate 3 received %d votes.\n", candidate3);
        
    } else {
        printf("Invaild input. Try again.");
    }
    return 0;
}