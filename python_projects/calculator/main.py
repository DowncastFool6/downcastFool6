import art

# Declaring functions for each operator
def add(n1, n2):
    return n1 + n2

def subtract(n1, n2):
    return n1 - n2

def divide(n1, n2):
    return n1 / n2

def multiply(n1, n2):
    return n1 * n2

# Storing the symbols as key and the functions as value in a dictionary
operations = {
    "+": add,
    "-": subtract,
    "*": multiply,
    "/": divide,
}

# Creating a function called caluclator
def calculator():
    print(art.logo)

    # Asks user for the first number
    should_continue = True
    n1 = float(input("What is the first number?: "))

    while should_continue:
        # Prints out the operator symbols
        for symbol in operations:
            print(symbol)

        # Asks user for the operator's symbol and second number
        operation_symbol = input("Type which operator you want to use '+', '-', '*' or '/': ")
        n2 = float(input("What is the next number?: "))

        # Using the dictionary to perform the calculation
        result = operations[operation_symbol](n1, n2)
        print(f"{n1} {operation_symbol} {n2} = {result}")

        choice = input(f"Type 'y' to continue calculating with {result}, or type 'n' to start a new calculation: ").lower()

        if choice == "y":
            # Storing the result as the first number
            n1 = result
        else:
            # Calling function to a new calculation
            should_continue = False
            print("\n"  * 50)
            calculator()

# Calling function to starts the program
calculator()


# Using function to perform the calculation
# operator = multiply
# print(operator(4, 8))

# Calls function
# print(add(2, 3))

# Syntax for storing the function as a variable
# favourite_operation = add
# print(favourite_operation(2, 3))

