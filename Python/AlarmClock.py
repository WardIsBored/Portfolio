import os
import winsound

def start():
    os.system("cls" or "clear")
    print("alarm clock")
    time = input("How many seconds do you want it to count down from: ")
    if not time.isdigit():
        print("Please enter a valid number(INTEGER)")
        start()
        return
    for i in range(int(time), 0, -1):
        os.system("cls" or "clear")
        print(i)
        os.system("timeout /t 1 >nul" if os.name == "nt" else "sleep 1")
    print("Time's up! Press Enter to stop the alarm.")
    import threading

    stop = False
    def beep_loop():
        while not stop:
            winsound.Beep(1000, 1000)
            os.system("timeout /t 1 >nul")
    t = threading.Thread(target=beep_loop)
    t.start()
    input()  # Wait for Enter
    stop = True
    t.join()
    input("Press Enter to set another alarm...")
    start()
start()