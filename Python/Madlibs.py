import random
import os
# MADLIBS GENERATOR!

places = [
    "New York", "Paris", "Tokyo", "Sydney", "Cairo", "Rio de Janeiro", "Mumbai", "Moscow",
    "Beijing", "London", "Berlin", "Rome", "Madrid", "Bangkok", "Cape Town", "Toronto",
    "Los Angeles", "Hong Kong", "Dubai", "Singapore", "Istanbul", "Seoul", "Vienna", "Barcelona",
    "Buenos Aires", "Amsterdam", "Lagos", "Chicago", "Shanghai", "Lisbon", "Athens", "Oslo",
    "Stockholm", "Helsinki", "Dublin", "Prague", "Budapest", "Warsaw", "Zurich", "Geneva",
    "Vancouver", "Melbourne", "Auckland", "Cape Verde", "Havana", "Caracas", "Lima", "Bogotá",
    "Santiago", "Montreal", "Mexico City", "San Francisco", "Seattle", "Boston", "Houston",
    "Atlanta", "Miami", "Dallas", "Phoenix", "Denver", "Las Vegas", "Amsterdam", "Brussels",
    "Copenhagen", "Stockholm", "Osaka", "Kyoto", "Nagoya", "Seville", "Valencia", "Malaga",
    "Lyon", "Marseille", "Nice", "Florence", "Venice", "Milan", "Turin", "Naples", "Palermo",
    "Bali", "Phuket", "Honolulu", "Reykjavik", "Oslo", "Edinburgh", "Glasgow", "Lisbon",
    "Porto", "Valletta", "Warsaw", "Krakow", "Gdańsk", "Vilnius", "Riga", "Tallinn", "Zagreb",
    "Belgrade", "Sarajevo", "Ljubljana", "Athens", "Thessaloniki", "Istanbul"
]
nouns = [
    "time", "person", "year", "way", "day", "thing", "man", "woman", "life", "child",
    "world", "school", "state", "family", "student", "group", "country", "problem",
    "work", "job", "city", "home", "week", "room", "power", "government", "company",
    "number", "night", "point", "place", "water", "area", "mother", "father", "head",
    "eye", "hand", "door", "face", "friend", "book", "word", "car", "idea", "moment",
    "order", "market", "fact", "law", "story", "food", "side", "service", "name", "line",
    "end", "community", "school", "event", "body", "mind", "office", "force", "woman",
    "course", "society", "team", "lawyer", "chance", "moment", "effect", "role",
    "talk", "children", "air", "weather", "water", "road", "light", "mother", "father",
    "death", "difference", "reason", "music", "science", "education", "health", "book",
    "picture", "history", "program", "research", "love", "friendship", "motion",
    "language", "question", "answer", "city", "village"
]
verbs = [
    "run", "jump", "swim", "read", "write", "drive", "walk", "talk", "eat", "drink",
    "sleep", "wake", "think", "imagine", "remember", "forget", "love", "hate", "like", "dislike",
    "want", "need", "use", "create", "build", "destroy", "fix", "repair", "fly", "travel",
    "climb", "surf", "ski", "skate", "bike", "hike", "explore", "discover", "solve", "learn",
    "teach", "help", "support", "encourage", "call", "listen", "watch", "play", "move", "stay"
]
adjectives = [
    "adorable", "amused", "blushing", "cloudy", "naughty", "putrid", "odd", "nervous", "puzzled",
    "dead", "different", "faithful", "cute", "envious", "awful", "clean", "bloody", "condemned",
    "selfish", "attractive", "bewildered", "drab", "charming", "filthy", "fragile", "friendly",
    "gentle", "gleaming", "gorgeous", "dangerous", "evil", "breakable", "aggressive", "annoyed",
    "brainy", "colorful", "average", "black", "dull", "cheerful", "cooperative", "careful",
    "creepy", "defiant", "disgusted", "fancy", "dark", "excited", "bright", "lazy", "lucky",
    "outrageous", "real", "mushy", "nutty", "tired", "precious", "shiny", "poised", "sleepy",
    "stupid", "tender", "witty", "spotless", "vivacious", "perfect", "light", "magnificent",
    "outstanding", "relieved", "mysterious", "obedient", "tough", "prickly", "shy", "poor",
    "smiling", "successful", "tense", "worried", "stormy", "wandering", "plain", "lively",
    "misty", "fantastic", "fine", "frail", "frightened", "gifted", "glorious", "graceful",
    "kind", "smoggy", "super", "terrible", "worrisome", "strange", "weary", "pleasant"
]
public_figures = [
    "Nelson Mandela",
    "Mahatma Gandhi",
    "Albert Einstein",
    "Martin Luther King Jr.",
    "Mother Teresa",
    "Winston Churchill",
    "Adolf Hitler",
    "Joseph Stalin",
    "Vladimir Lenin",
    "Mao Zedong",
    "Abraham Lincoln",
    "George Washington",
    "Barack Obama",
    "Donald Trump",
    "Joe Biden",
    "Angela Merkel",
    "Margaret Thatcher",
    "Franklin D. Roosevelt",
    "John F. Kennedy",
    "Richard Nixon",
    "Theodore Roosevelt",
    "Benjamin Franklin",
    "Elizabeth II",
    "Queen Victoria",
    "Pope Francis",
    "Pope John Paul II",
    "Muhammad Ali",
    "LeBron James",
    "Michael Jordan",
    "Bill Gates",
    "Steve Jobs",
    "Elon Musk",
    "Jeff Bezos",
    "Mark Zuckerberg",
    "Warren Buffett",
    "Oprah Winfrey",
    "Kate Middleton",
    "Princess Diana",
    "Taylor Swift",
    "Beyoncé",
    "Rihanna",
    "Michael Jackson",
    "Madonna",
    "Elvis Presley",
    "Bob Dylan",
    "Leonardo DiCaprio",
    "Angelina Jolie",
    "Brad Pitt",
    "Johnny Depp",
    "Kim Kardashian",
    "Kanye West",
    "Justin Bieber",
    "Ariana Grande",
    "Shakira",
    "Ed Sheeran",
    "Billie Eilish",
    "Greta Thunberg",
    "Malala Yousafzai",
    "Nelson Rolihlahla Mandela",
    "Che Guevara",
    "Vladimir Putin",
    "Xi Jinping",
    "Kim Jong-un",
    "Mohandas Karamchand Gandhi",
    "Genghis Khan",
    "Cleopatra",
    "Julius Caesar",
    "Alexander the Great",
    "Napoleon Bonaparte",
    "Florence Nightingale",
    "Louis Pasteur",
    "Marie Curie",
    "Isaac Newton",
    "Galileo Galilei",
    "Charles Darwin",
    "Stephen Hawking",
    "Nikola Tesla",
    "Ada Lovelace",
    "Alan Turing",
    "Rosa Parks",
    "Harriet Tubman",
    "Frederick Douglass",
    "Sojourner Truth",
    "Nelson Mandela",  # duplicate, but shows up often
    "Desmond Tutu",
    "Dalai Lama",
    "Simon Bolivar",
    "Martin Luther",
    "Johannes Gutenberg",
    "Christopher Columbus",
    "Vladimir Nabokov",
    "Fyodor Dostoevsky",
    "William Shakespeare",
    "Jane Austen",
    "Mark Twain",
    "J.K. Rowling",
    "George Orwell",
    "Ernest Hemingway"
]
biblical_places = [
    "Jerusalem", "Bethlehem", "Nazareth", "Galilee", "Samaria", "Judea", "Capernaum", "Gethsemane",
    "Jericho", "Hebron", "Bethany", "Damascus", "Nineveh", "Babylon", "Egypt", "Canaan", "Eden",
    "Sinai", "Jordan", "Gaza", "Tyre", "Sidon", "Beersheba", "Bethel", "Ashkelon", "Ashdod",
    "Shiloh", "Gilgal", "Gilead", "Aram", "Assyria", "Moab", "Ammon", "Midian", "Edom", "Phoenicia",
    "Byblos", "Attalia", "Laodicea", "Antioch", "Pergamos", "Babylonia", "Tarshish", "Ararat",
    "Haran", "Pisgah", "Mount Zion", "Mount Carmel", "Mount Sinai", "Mount Nebo", "Bethsaida",
    "Bochim", "Ono", "Ekron", "Calah", "Calneh", "Debir", "Dothan", "Elim", "Enoch", "Esdraelon",
    "Etham", "Gabbatha", "Golgotha", "Havilah", "Jabbok", "Jaffa", "Jerash", "Judah", "Judea",
    "Kadesh-Barnea", "Kiriath-Jearim", "Lachish", "Laish", "Lebanon", "Machpela", "Mamre",
    "Marah", "Megiddo", "Memphis", "Nazareth", "Perga", "Petra", "Philistia", "Resen", "Rephidim",
    "Sodom", "Gomorrah", "Zoar", "Church", "Shechem", "Siloam", "Siloah", "Pathos", "Patmos"
]
biblical_figures = [
    "Adam", "Eve", "Noah", "Abraham", "Sarah", "Isaac", "Rebekah", "Jacob", "Esau", "Joseph",
    "Moses", "Aaron", "Miriam", "Joshua", "Caleb", "Deborah", "Gideon", "Samson", "Ruth", "Boaz",
    "Samuel", "Saul", "David", "Jonathan", "Bathsheba", "Solomon", "Rehoboam", "Elijah", "Elisha",
    "Ahab", "Jezebel", "Isaiah", "Jeremiah", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah",
    "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Mary",
    "Joseph (husband of Mary)", "Jesus Christ", "John the Baptist", "Peter", "James", "John (the Apostle)",
    "Andrew", "Philip", "Bartholomew", "Matthew", "Thomas", "James (son of Alphaeus)", "Thaddaeus",
    "Simon the Zealot", "Judas Iscariot", "Paul (Saul of Tarsus)", "Barnabas", "Silas", "Timothy", "Titus",
    "Priscilla", "Aquila", "Stephen", "Philip the Evangelist", "Cornelius", "Lydia", "Damaris", "Euodia",
    "Syntyche", "Ananias (of Damascus)", "Sapphira", "Herod the Great", "Herod Antipas", "Pontius Pilate",
    "Nicodemus", "Joseph of Arimathea", "Mary Magdalene", "Martha", "Lazarus", "Zacchaeus", "Bartimaeus",
    "Mary (mother of James and Joses)", "Salome", "Joanna", "Cleopas", "Luke", "Mark", "Matthew (the Evangelist)",
    "John Mark", "Timothy", "Tertius", "Phoebe", "Apollos", "Epaphras", "Onesimus", "Philemon", "Archippus",
    "Epaphras", "Eutychus", "Demas", "Alexander (the coppersmith)", "Crispus", "Gaius", "Trophimus", "Erastus",
    "Sosthenes", "Chloe", "Clement", "Hermas", "Ignatius of Antioch", "Polycarp", "Irenaeus", "Origen", "Tertullian"
]
activities = [
    "eat breakfast", "go for a walk", "read a book", "watch a movie", "listen to music", "exercise", "cook dinner", "clean the house", "call a friend", "write in a journal",
    "play a sport", "go shopping", "attend a meeting", "study for an exam", "take a nap", "do laundry", "water the plants", "play a video game", "browse social media", "meditate",
    "practice a hobby", "organize the closet", "plan the week", "go to the gym", "attend a class", "volunteer", "go to a concert", "travel to a new city", "try a new recipe", "take a photograph",
    "go to a museum", "watch a documentary", "go hiking", "ride a bike", "go to the beach", "have a picnic", "attend a wedding", "celebrate a birthday", "go to a party", "host a dinner",
    "go camping", "go fishing", "go skiing", "go snowboarding", "attend a sports game", "go to a theme park", "visit a zoo", "go to a spa", "get a massage", "take a yoga class",
    "go to a farmer's market", "attend a festival", "go to a comedy show", "watch a play", "go bowling", "play board games", "do a puzzle", "go to a karaoke bar", "go to a nightclub", "go to a bar",
    "go to a coffee shop", "try a new restaurant", "go to a food truck", "have a barbecue", "bake cookies", "make homemade ice cream", "make a smoothie", "try a new workout", "go to a dance class", "learn a new language",
    "take a cooking class", "learn to play an instrument", "take a photography class", "learn to knit", "start a blog", "start a podcast", "write a short story", "write a poem", "start a garden", "learn to juggle",
    "take a pottery class", "learn to surf", "go rock climbing", "go skydiving", "go bungee jumping", "take a hot air balloon ride", "go scuba diving", "go snorkeling", "go whitewater rafting", "go ziplining",
    "go to a drive-in movie", "go on a road trip", "visit a national park", "go to a historical site", "go to a botanical garden", "go to an aquarium", "go to a planetarium", "go to a science center", "go to a library", "go to a bookstore",
    "go to a thrift store", "go to an antique shop", "go to a flea market", "go to a craft fair", "go to a car show", "go to a pet store", "go to a farmer's market", "go to a food festival", "go to a wine tasting", "go to a brewery tour"
]


def start():
    print("You wake up in " + random.choice(places) + ".")
    input("Press Enter to continue...")
    print("You see a " + random.choice(adjectives) + " " + random.choice(nouns) + " nearby.")
    input("Press Enter to continue...")
    print("You decide to " + random.choice(verbs) + " towards it.")
    input("Press Enter to continue...")
    print("Suddenly, a " + random.choice(adjectives) + " " + random.choice(nouns) + " appears!")
    input("Press Enter to continue...")
    print("You feel " + random.choice(adjectives) + " and " + random.choice(adjectives) + ".")
    input("Press Enter to continue...")
    print("Out of nowhere, " + random.choice(public_figures) + " shows up and offers to help you.")
    input("Press Enter to continue...")
    print("Together, you both decide to " + random.choice(verbs) + " away from the danger.")
    input("Press Enter to continue...")
    print("Suddenly, ", random.choice(biblical_figures) + " appears and guides you to ", random.choice(biblical_places) + ".")
    input("Press Enter to continue...")
    print("But suddenly, you have an urge to ", random.choice(activities) + ".")
    input("Press Enter to continue...")
    print("But you remember in ", random.choice(biblical_places)," ,", random.choice(biblical_figures), " once said to not do that.")
    input("Press Enter to continue...")
    print("Suddenly, ", random.choice(public_figures), " Appears out the ground and then tells you to ", random.choice(verbs) + " to " + random.choice(adjectives) + " ", random.choice(nouns))
    input("Press Enter to continue...")
    print("the end")
    os.system('cls' if os.name == 'nt' else 'clear')
    start()
start()