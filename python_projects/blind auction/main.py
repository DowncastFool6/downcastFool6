import art
print(art.logo)

def find_highest_bidder(bidding_dictionary):
    highest_bid = 0
    winner = ''

    for bidder in bidding_dictionary:
        bid_amount = bidding_dictionary[bidder]
        if bid_amount > highest_bid:
            highest_bid = bid_amount
            winner = bidder

    # Alternative solution
    # max(bids, key=bids.get)

    print(f"The winner is {winner} with a bid of €{highest_bid}.")

bids = {}

continue_bidding = True
while continue_bidding:
    name = input("What is your name? ")
    price = float(input("What is your bid? €"))
    bids[name] = price
    answer = input("Are there other users who want to bidders? Type 'yes' or 'no'? ").lower()

    if answer == 'no':
        continue_bidding = False
        find_highest_bidder(bids)
    elif answer == 'yes':
        print("\n" * 100)

# TODO-1: Ask the user for input
# TODO-2: Save data into dictionary {name: price}
# TODO-3: Whether if new bids need to be added
# TODO-4: Compare bids in dictionary
