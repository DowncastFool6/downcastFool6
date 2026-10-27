#include <stdio.h>

int main() {
    int movie_hour, movie_mins, arrival_hour, arrival_mins, movie_total, arrival_total;

    printf("Indicate the time the movie starts, first the hours then the mins: \n");
    scanf("%d", &movie_hour);
    scanf("%d", &movie_mins);

    printf("Indicate the time the client arrived, first the hours then the mins: \n");
    scanf("%d", &arrival_hour);
    scanf("%d", &arrival_mins);

    movie_total = (movie_hour * 60) + movie_mins;
    arrival_total = (arrival_hour * 60) + arrival_mins;

    if (arrival_total <= movie_total - 30) {
        printf("Client arrived early, they can wait.\n");
    } else if (arrival_total >= movie_total + 15) {
        printf("Client arrived late, they may enter.\n");
    } else {
        printf("Client cannot enter, movie unavailable.\n");
    }

    return 0;
}