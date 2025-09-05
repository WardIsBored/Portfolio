#barista

#functions!

def banner():
    print("""
██████╗  █████╗ ██████╗ ██╗███████╗████████╗ █████╗ 
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝╚══██╔══╝██╔══██╗
██████╔╝███████║██████╔╝██║███████╗   ██║   ███████║
██╔══██╗██╔══██║██╔══██╗██║╚════██║   ██║   ██╔══██║
██████╔╝██║  ██║██║  ██║██║███████║   ██║   ██║  ██║
╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝
                                                    """)

def take_order():
    global money
    print("Your money is: $", money)
    print("Here is the menu: ")
    for item, price in menu.items():
        print(f"{item.capitalize()}: ${price:.2f}")
    order_input = input("What would you like to order? (use * for quantity, e.g. coffee*3): ").lower()
    if "*" in order_input:
        order, qty_str = order_input.split("*", 1)
        order = order.strip()
        try:
            quantity = int(qty_str.strip())
            if quantity < 1:
                print("Please enter a valid quantity.")
                return
        except ValueError:
            print("Invalid quantity.")
            return
    else:
        order = order_input.strip()
        quantity = 1

    if order in menu:
        total_cost = menu[order] * quantity
        if money >= total_cost:
            print("\n" * 3)
            print(f"You ordered {quantity} {order}(s). Enjoy!")
            money -= total_cost
            # Update inventory
            if order in inventory:
                inventory[order] += quantity
            else:
                inventory[order] = quantity
        else:
            print("You don't have enough money for that.")
    else:
        print("That item is not on the menu.")

def work():
    global money
    if job == "barista":
        print("You made some coffee! +$5")
        money += 5
    elif job == "cashier":
        print("You handled some transactions! +$7")
        money += 7
    elif job == "manager":
        print("You managed the cafe! +$10")
        money += 10

def inventory_check():
    print("Current inventory:")
    for item, quantity in inventory.items():
        print(f"{item.capitalize()}: {quantity}")
    if not inventory:
        print("Your inventory is empty.")

def eat_food():
    global hunger
    if not inventory:
        print("You have no food to eat.")
        return
    edible_items = [item for item in inventory if inventory[item] > 0]
    if not edible_items:
        print("You have no food to eat.")
        return
    print("Your inventory:")
    for idx, item in enumerate(edible_items, 1):
        print(f"{idx}. {item.capitalize()} (x{inventory[item]})")
    choice = input("What would you like to eat? (type name or number): ").lower()
    selected = None
    if choice.isdigit():
        idx = int(choice) - 1
        if 0 <= idx < len(edible_items):
            selected = edible_items[idx]
    else:
        for item in edible_items:
            if item == choice:
                selected = item
                break
    if selected:
        print(f"You eat the {selected}. +5 hunger.")
        hunger = min(hunger + 20, 100)
        inventory[selected] -= 1
        if inventory[selected] <= 0:
            del inventory[selected]
    else:
        print("Invalid choice.")

#start of program
opening_line = "Welcome to the cafe! What would you like to order?"

starting_line = "Welcome to the cafe! Please select a job."

print(opening_line)

menu = {
    "coffee": 3.00,
    "tea": 2.50,
    "sandwich": 5.00,
    "cake": 4.00
}

inventory = {
    "sandwich": 1,
}

day = 1

jobs = ["barista", "cashier", "manager"]
print("Available jobs:")
for job_option in jobs:
    print(f"- {job_option}")
job = input("Please enter your job: ")

money = 20.00

hunger = 100

clear = "\n" * 100
print(clear)

def action():
    global hunger
    hunger -= 10
    #main function to handle actions
    banner()
    print("\n" * 3)
    print("Welcome to the cafe!")
    print("You have $", money)
    print ("Your job is:", job)
    print("Your hunger level is:", hunger)

    current_action = input("What would you like to do? (order/work/inventory/eat): ").lower()

    if hunger <= 0:
        print("\n" * 3)
        print("You are too hungry to continue! Game over.")
        return
    if money <= 0:
        print("\n" * 3)
        print("You have no money left! Game over.")
        return
    if current_action == "order":
        print("\n" * 3)
        take_order()
        action()
    if current_action == "work":
        print("\n" * 3)
        work()
        action()
    if current_action == "inventory":
        inventory_check()
        action()
    if current_action == "eat":
        print("\n" * 3)
        eat_food()
        action()
action()