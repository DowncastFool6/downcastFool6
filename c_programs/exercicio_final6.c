#include <stdio.h>

int main() {
    
    float tempF, tempC;
    
    printf("Enter a temperature in Fahrenheit to convert to Celsius: ");
    scanf("%f", &tempF);
    
    tempC = 5 * (tempF - 32) / 9;

    printf("The temperature in Celsuis is: %.2f", tempC);
    
    return 0;
}