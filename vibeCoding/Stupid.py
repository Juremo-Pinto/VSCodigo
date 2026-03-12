# Ao bobão que decidiu achar isso, se quizer brincar brinque, adicione a brincadeira, o código é seu!

def main():
    answer = input("Are you stupid? (yes/no)\n").strip().lower()

    if answer == "yes":
        print("\nSTUPID HAHA FUNNY!!!")
        input("\nPress Enter to exit...")
        return

    if answer == "no":
        num = input("What's 9 + 10? \n").strip()
        try:
            n = int(num)
        except ValueError:
            print("\nThat's not... what???")
            input("\nPress Enter to exit...")
            return

        if n == 19:
            print("\nGood job!!")
        elif n == 21:
            print("\nSo ur silly huh??")
        else:
            print("\nStupid.")

        input("\nPress Enter to exit...")
        return

    print("\nFuck you even mean to do with that?")
    input("\nPress Enter to exit...")


if __name__ == '__main__':
    main()