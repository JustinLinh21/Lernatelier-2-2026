
import random

spieler_punkte = 0
computer_punkte = 0

print("=== SCHERE, STEIN, PAPIER ===")

for runde in range(1, 6):
    print(f"\nRunde {runde} von 5")

    spieler = input("Wähle Schere, Stein oder Papier: ").lower()
    computer = random.choice(["schere", "stein", "papier"])

    print("Computer wählt:", computer)

    if spieler not in ["schere", "stein", "papier"]:
        print("Ungültige Eingabe! Du verlierst diese Runde.")
        computer_punkte += 1

    elif spieler == computer:
        print("Unentschieden!")

    elif (
        (spieler == "schere" and computer == "papier")
        or (spieler == "stein" and computer == "schere")
        or (spieler == "papier" and computer == "stein")
    ):
        print("Du gewinnst die Runde!")
        spieler_punkte += 1

    else:
        print("Der Computer gewinnt die Runde!")
        computer_punkte += 1

print("\n=== ENDERGEBNIS ===")
print("Deine Punkte:", spieler_punkte)
print("Computer-Punkte:", computer_punkte)

if spieler_punkte > computer_punkte:
    print("Du hast das Spiel gewonnen!")
elif spieler_punkte < computer_punkte:
    print("Der Computer hat das Spiel gewonnen!")
else:
    print("Das Spiel endet unentschieden!")
