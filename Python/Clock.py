import time

def update_time():
    print("Current time:", time.strftime(("%H:%M")))

while True:
    update_time()
    time.sleep(60)
    print("\n" * 100)