import time
import os

def update_time():
    print("Current time:", time.strftime("%H:%M:%S", time.localtime()))

while True:
    update_time()
    time.sleep(1)
    os.system("cls" or "clear")