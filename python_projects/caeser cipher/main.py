import art

print(art.logo)

# Declaration of a dictionary
alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']

# Creating a function to encrypt or decrypt text
def caesar(original_text, shift_amount, encode_or_decode):
    # Initializes variable as string
    output_text = ""

    # Verifying if user wants to decode
    if encode_or_decode == "decode":
        # Shifts each letter backwards based on the shift amount
        shift_amount *= -1

    # To preserve the spaces and symbols within a text
    for letter in original_text:
        if letter not in alphabet:
            output_text += letter
        else:
            # Shifts each letter forward based on the shift amount
            shifted_position = alphabet.index(letter) + shift_amount
            shifted_position %= len(alphabet)
            output_text += alphabet[shifted_position]
    
    # Prints out the ciphered text
    print(f"Here is the {encode_or_decode}d result: {output_text}")

should_continue = True

while should_continue:

    # Asks user whether to encypt or decrypt
    direction = input("Type 'encode' to encrypt, type 'decode' to decrypt:\n").lower()
    
    # Asks user to input the message to cipher
    text = input("Type your message:\n").lower()
    
    # Asks user the amount of shift
    shift = int(input("Type the shift number:\n"))

    # Using the function to assign the parameters and arguments
    caesar(original_text=text, shift_amount=shift, encode_or_decode=direction)

    # Whether to restart the cipher program or not?
    restart = input("Type 'yes' if you want to go again.Otherwise, type 'no':\n").lower()
    if restart == "no":
        should_continue = False
        print("Goodbye!")