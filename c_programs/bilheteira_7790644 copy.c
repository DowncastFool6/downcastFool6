// Nome: Vissolela Cundi
// Número: 7790644

#include <stdio.h>

int main() {
    int hourFilme, minFilme, option, age, totalTickets, hourArrive, minArrive, arriveTotal, movieTotal, difference, roomSeats, freeSeats;
    float price, averageAge, occupancyRate;

    int childTicket = 0, adultTicket = 0, seniorTicket = 0;
    int ageTotal = 0;
    int youngest = 0, oldest = 0;
    float totalInvoice = 0.0;

    printf("O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O\n");
    printf("O       WELCOME TO THE CINEMA!      O\n");
    printf("O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O=O\n");

    printf("\nIndicate the time the movie starts, first the hours then the mins: \n");
    scanf("%d", &hourFilme);
    scanf("%d", &minFilme);

    while (hourFilme < 0 || hourFilme > 23 || minFilme < 0 || minFilme > 59) {
        printf("Invalid hour or minutes! Try again: \n");
        scanf("%d", &hourFilme);
        scanf("%d", &minFilme);
    }

    printf("\nIndicate the day of the week: \n1 = Monday \n2 = Tuesday \n3 = Wednesday \n4 = Thursday \n5 = Friday \n6 = Saturday \n7 = Sunday: ");
    int dayOfWeek;
    scanf("%d", &dayOfWeek);

    printf("\nIndicate the number of seats in the room: \n");
    scanf("%d", &roomSeats);

    option = 1;

    while (option != 0) {
        printf("\nSelect and type a number from the menu.\n");
        printf("1 - Buy Tickets \n2 - Entry Time \n3 - Statistics \n0 - Review and Close Program\n");
        scanf("%d", &option);

        if (option == 1) {
            totalTickets = childTicket + adultTicket + seniorTicket;

            if (totalTickets >= roomSeats) {
                printf("Room full.\n");
                continue; // Se a sala está cheia, volta ao menu sem vender mais
            }

            printf("\nIndicate your age: \n");
            scanf("%d", &age);

            while (age < 0 || age > 120) {
                printf("Invalid age! Try again: \n");
                scanf("%d", &age);
            }

            ageTotal = ageTotal + age;

            if (totalTickets == 0) {
                youngest = age;
                oldest = age;
            } else {
                if (age < youngest)
                    youngest = age;
                if (age > oldest)
                    oldest = age;
            }

            if (age <= 11) {
                price = 5;
                childTicket++;
            } else if (age >= 65) {
                price = 6;
                seniorTicket++;
            } else {
                price = 8;
                adultTicket++;

                if (age >= 12 && age <= 25) {
                    int studentCard;
                    printf("Do you have a student card? (1 = Yes, 0 = No): ");
                    scanf("%d", &studentCard);
                    if (studentCard == 1) {
                        price = 6.50; // Estudantes jovens pagam menos
                    }
                }
            }

            if (dayOfWeek == 2) { // Terça-feira tem 20% de desconto
                price = price * 0.8;
            }

            totalInvoice = totalInvoice + price;
            printf("Price: %.2f€.\n", price);

        } else if (option == 2) {
            printf("\nIndicate the time the client arrived, first the hours then the mins: \n");
            scanf("%d", &hourArrive);
            scanf("%d", &minArrive);

            while (hourArrive < 0 || hourArrive > 23 || minArrive < 0 || minArrive > 59) {
                printf("Invalid hour or minutes! Try again: \n");
                scanf("%d", &hourArrive);
                scanf("%d", &minArrive);
            }

            movieTotal = (hourFilme * 60) + minFilme;
            arriveTotal = (hourArrive * 60) + minArrive;
            difference = movieTotal - arriveTotal;

            // Se o filme começar ao meio-dia e o cliente chegar à meia-noite,
            // um valor entre -12 e +12 horas, para funcionar mesmo quando
            // a chegada é antes ou depois da meia-noite.
            if (difference > 720)
                difference -= 1440;
            else if (difference < -720)
                difference += 1440;

            if (difference > 30) {
                printf("Still early. Client must wait %d minutes.\n", difference - 30);
            } else if (difference >= -15) {
                printf("Client can enter the room.\n");
            } else {
                printf("Client cannot enter the room anymore.\n");
            }

        } else if (option == 3) {
            totalTickets = childTicket + adultTicket + seniorTicket;

            printf("\n");
            printf(" .--------------------. \n");
            printf("(    Ticket Summary    )\n");
            printf(" '--------------------' \n\n");

            if (totalTickets == 0) {
                printf("No tickets sold.\n");
            } else {
                printf("Total tickets sold: %d (children: %d, adults: %d, seniors: %d)\n", totalTickets, childTicket, adultTicket, seniorTicket);
                printf("Total invoice: %.2f€\n", totalInvoice);

                averageAge = (float)ageTotal / totalTickets; // (float) converte para decimal para a divisão não dar erro
                printf("Average age: %.2f years\n", averageAge);

                freeSeats = roomSeats - totalTickets;
                occupancyRate = (float)totalTickets / roomSeats * 100;
                printf("Free seats: %d | Occupancy rate: %.2f%%\n", freeSeats, occupancyRate);

                printf("Youngest client: %d years | Oldest client: %d years\n", youngest, oldest);
            }

        } else if (option == 0) {
            int confirm;
            printf("Are you sure you want to exit? (1 = Yes, 0 = No): ");
            scanf("%d", &confirm);

            if (confirm == 0) {
                option = 1; // Muda a opção para voltar ao menu
            } else {
                totalTickets = childTicket + adultTicket + seniorTicket;

                printf("\n");
                printf(" .-------------------. \n");
                printf("(    Final Summary    )\n");
                printf(" '-------------------' \n\n");

                printf("Total tickets sold: %d\n", totalTickets);
                printf("Children: %d, Adults: %d, Seniors: %d\n", childTicket, adultTicket, seniorTicket);
                printf("Total invoice: %.2f€\n\n", totalInvoice);

                printf("   ___________________________\n");
                printf("  |                           |\n");
                printf("  | Visit us again, goodbye!  |\n");
                printf("  |___________________________|\n");
                printf("        ||           ||\n");
                printf("        ||           ||\n");
                printf("  ===========================\n\n\n");
            }
        } else {
            printf("\nInvalid option. Choose 1, 2, 3 or 0.\n");
        }
    }
    printf("\n\n\n\n");
    printf("< Está aprovado? Baa! >\n");
    printf(" ----------------\n");
    printf("      \\\n");
    printf("       \\  .@@@@.\n");
    printf("        \\(@@@@@@)\n");
    printf("         ( o  o )\n");
    printf("          (____)\n");
    printf("           ||||\n\n\n");

    return 0;
}