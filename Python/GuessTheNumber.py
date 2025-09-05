# GUESS THE NUMBER!
import random
# So hardcore it hurtss (no diddly)

def banner():
    print("""
          
 ██████╗ ██╗   ██╗███████╗███████╗███████╗    ████████╗██╗  ██╗███████╗    ███╗   ██╗██╗   ██╗███╗   ███╗██████╗ ███████╗██████╗ ██╗
██╔════╝ ██║   ██║██╔════╝██╔════╝██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ████╗  ██║██║   ██║████╗ ████║██╔══██╗██╔════╝██╔══██╗██║
██║  ███╗██║   ██║█████╗  ███████╗███████╗       ██║   ███████║█████╗      ██╔██╗ ██║██║   ██║██╔████╔██║██████╔╝█████╗  ██████╔╝██║
██║   ██║██║   ██║██╔══╝  ╚════██║╚════██║       ██║   ██╔══██║██╔══╝      ██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██╗██╔══╝  ██╔══██╗╚═╝
╚██████╔╝╚██████╔╝███████╗███████║███████║       ██║   ██║  ██║███████╗    ██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██████╔╝███████╗██║  ██║██╗
 ╚═════╝  ╚═════╝ ╚══════╝╚══════╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝╚═╝
                                                                                                                                    """)

number_to_guess = random.randint(1, 100)
attempts = 0
max_attempts = 10

def VoiceLines():
    print("Welcome to Guess The Number!")
    print("I am thinking of a number between 1 and 100.")
    print("You have 10 attempts to guess the number.")
    print("Good luck!")

def Guess():
    global attempts
    global max_attempts
    global number_to_guess
    attempts += 1
    if attempts <= max_attempts:
        current_guess = int(input("Enter your guess (INTEGER): "))
        print(f"You have {max_attempts - attempts} attempts left.")
        if current_guess - number_to_guess >= 5:
            print("You're getting warm!")
        if current_guess - number_to_guess < 5:
            print("You're pretty cold!")
        if current_guess < number_to_guess:
            print("Too Low!")
            Guess()
        elif current_guess > number_to_guess:
            print("Too High!")
            Guess()
        else:
            print("Congratulations! You guessed the number!")
            return
    else:
        print("Sorry, you've run out of attempts. The number was", number_to_guess)
        return

def guess_the_number():
    banner()
    VoiceLines()
    Guess()
guess_the_number()

