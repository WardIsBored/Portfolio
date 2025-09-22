import os

def start():
    print("Welcome to the Mad Libs2 game!")
    print("Please provide the following words:")
    noun1 = input("Noun: ")
    noun2 = input("Another noun: ")
    verb1 = input("Verb: ")
    adjective1 = input("Adjective: ")
    adverb1 = input("Adverb: ")
    place1 = input("Place: ")
    number1 = input("Number: ")
    color1 = input("Color: ")
    animal1 = input("Animal: ")
    food1 = input("Food: ")
    print("\nHere's your story:\n")
    story = f"""Once upon a time in a {adjective1} land,
      there was a {color1} {animal1} named {noun1}.
    Every day, {noun1} would {verb1} {adverb1} to the {place1}.
     One day, {noun1} found a magical {noun2} that granted {number1} wishes. 
     Excitedly, {noun1} wished for an endless supply of {food1}. 
     And so, {noun1} lived happily ever after with lots of delicious {food1}!"""
    print(story)
    print("\nThank you for playing Mad Libs2!")
    input("Press Enter to play again...")
    os.system("cls" or "clear")
    start()
start()
