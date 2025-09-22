import os
#variables
tasks = []
#functions
def Start():
    print("1) Add Task")
    print("2) View Tasks")
    print("3) Remove Task")
    print("4) Extract Tasks")
    print("5) Exit")
    choice = input("Choose an option: ")
    if choice == '1': 
        AddTask()
    elif choice == '2':
        print(tasks)
        input("Press Enter to continue...")
        os.system("cls" or "clear")
    elif choice == '3':
        RemoveTask()
    elif choice == '4':
         ExtractTasks()
    elif choice == '5':
        print("Exiting...")
        exit()
    Start()

def ExtractTasks():
    with open("tasks.txt", "w") as f:
        for task in tasks:
            f.write(task + "\n")
    print("Tasks extracted to tasks.txt")
    input("Press Enter to continue...")
    os.system("cls" or "clear")
    return tasks

def RemoveTask():
    task_to_remove = input("Enter the task you want to remove: ")
    if task_to_remove in tasks:
            tasks.remove(task_to_remove)
            print("Task Removed!")
    else:
        print("Task not found!")
        input("Press Enter to continue...")
        os.system("cls" or "clear")
    return tasks

def AddTask():
    global tasks
    task = input("Enter the task you want to add: ")
    print("Adding Task...")
    tasks.append(task)
    print("Task Added!")
    input("Press Enter to continue...")
    os.system("cls" or "clear")
    return tasks


#startup
Start()