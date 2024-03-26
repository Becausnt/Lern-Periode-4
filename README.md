# Lern-Periode 4
V. H. IM23w

20.2 bis 2.4.2024

## Grob-Planung

1. Mit meinen Noten bin ich momentan zufrieden und als besonders wichtig habe ich Modul 431 empfunden da es uns die Grundlagen des praktischen Prorgammierens beigebracht hat.
2. Mein letzter VBV war folgender:
   > Manchmal während dem Programmieren, inzwischen weniger als am Anfang, wenn ich über ein Problem nachdenke schweife ich mit den Gedanken ab und starre Löcher in meinen Monitor. Dies dauert aber meist nur kurze Zeit an, ist also nicht so ein grosses Problem.
4. **Neu**: Ich möchte einen discord-bot schreiben, welcher mit dem Benutzer TicTacToe oder so etwas spielt. (API)
5. Als ein geeignetes Projekt empfinde ich den obigen Vorschlag

## 20.2.2024

Heute habe ich mich dafür entschieden ein Projekt mit einem Discord-Bot zu machen. Ich bin einem Tutorial gefolgt und habe nach einige Probleme dank unterschiedlichen Versionen von libraries gehabt. Diese wurden mit einiger Hilfe aber gelöst. Nun habe ich ein Problem, da mein Bot erst den Inhalt von Nachrichten nicht erhielt, und nun gar keine Nachrichten mehr erhält.

## 27.2.2024

Heute habe ich mich dazu entsschieden an meinem SQL-Auftrag zu arbeiten, da ich daran noch einiges machen muss und wir für unser Projekt noch lange Zeit haben. Ich verschiebe die Arbeitspakete, welche ich heute gemacht haben sollte auf nächstes mal. zu meinen Arbeitspaketen habe ich noch folgendes zu sagen: Auch wenn TicTacToe Spiel funktionalität nich sehr schwierig scheinen mag, finde ich es doch noch kompliziert, da das Programm, welches Befehle Registriert und darauf registriert in einer Datei ist, das TicTacToe Spiel selbst jedoch in einer anderen. Zudem muss ich dafür sorgen das nur der Benutzer der den Befehl ausgeführt hat das Spiel spielen kann.
✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt
## 27.2.2024

- [x] Herausfinden wie der Bot Daten speichern kann und so mit dem Benutzer spiele spielen kann
- [x] TicTacToe-Spielfeld bauen
- [ ] TicTacToe spiel funktionalität bauen
- [ ] 1 Spiel pro benutzer

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1               | Bot gestartet, benutzer auf discord. | /button | Bot: Here's a button {Discord button} | Ja |
| 2               | Bot gestartet, benutzer auf discord. | /ping   | Bot: Pong! | Ja |
| 3               | Bot gestartet, benutzer auf discord. | /tictactoe | Bot: {TicTacToe Spielfeld}{Drop down list mit Zugmöglichkeiten} | Ja |

Heute habe ich mich dazu entsschieden an meinem SQL-Auftrag zu arbeiten, da ich daran noch einiges machen muss und wir für unser Projekt noch lange Zeit haben. Ich verschiebe die Arbeitspakete, welche ich heute gemacht haben sollte auf nächstes mal. zu meinen Arbeitspaketen habe ich noch folgendes zu sagen: Auch wenn TicTacToe Spiel funktionalität nich sehr schwierig scheinen mag, finde ich es doch noch kompliziert, da das Programm, welches Befehle Registriert und darauf registriert in einer Datei ist, das TicTacToe Spiel selbst jedoch in einer anderen. Zudem muss ich dafür sorgen das nur der Benutzer der den Befehl ausgeführt hat das Spiel spielen kann.
✍️ Heute habe ich... (50-100 Wörter)



## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).
## 19.2.2024

- [x] Im Modul M187 Auftrag 0710 fertig machen.
- [x] M187 Doku updaten
- [ ] TicTacToe spiel funktionalität bauen
- [ ] Score tracker

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1               | Bot gestartet, benutzer auf discord. | /button | Bot: Here's a button {Discord button} | Ja |
| 2               | Bot gestartet, benutzer auf discord. | /ping   | Bot: Pong! | Ja |
| 3               | Bot gestartet, benutzer auf discord /tictactoe eingegeben. | dropdown 1 | Bot: {TicTacToe Spielfeld}{Drop down list mit Zugmöglichkeiten} (Feld 1 = X) | Ja |


✍️ Heute habe ich... (50-100 Wörter)
Heute habe ich M187 Aufträge fertiggemacht, versucht eine Gewinnüberprüfung zu machen, das hat aber nicht so ganz geklappt. Das hier sollte Auf gewinn in einer Reihe überprüfen, aber vermutlich irgendwie werden die Fälle  falsch überprüft. Zudem habe ich an meiner Dokumentation fürs Modul 187 gearbeitet.
```C#
 switch (component.Data.CustomId)
 {
     case "menu1":

         int selectedField = Convert.ToInt32(component.Data.Values.First()) -1;
         if (!(playingField[selectedField] == 'X' || playingField[selectedField] == 'O'))
         {
             playingField[selectedField] = playerTurn;
         }   
         await component.RespondAsync($" {playingField[0]}|{playingField[1]}|{playingField[2]}\n{playingField[3]}|{playingField[4]}|{playingField[5]}\n{playingField[6]}|{playingField[7]}|{playingField[8]}", components: components.Build());

         var chnl = _client.GetChannel(1209402857380380683) as IMessageChannel;
         await chnl.SendMessageAsync($"Player {playerTurn} has won.");
         //await component.RespondAsync($"You selected {component.Data.Values.First()}"); // .First() ist das momentan ausgewählte


         // check rows
         for (int i = 0; i < 3; i++ )
         {
             if (playingField[i*3 + 1] == playerTurn && playingField[i*3 + 2] == playerTurn && playingField[i*3 + 3] == playerTurn)
             {
                
             }
         }

         playerTurn = playerTurn == 'X' ? 'O' : 'X'; // look up 'ternary operator'

         break;
 }
```
## 26.2.2024

- [x] /remindme hinzufügen
- [x] /coinflip hinzufügen
- [ ] TicTacToe spiel funktionalität bauen
- [x] Bugfixes

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1               | Bot gestartet, benutzer auf discord.  | /coinflip | The coin was Heads/Tails | Ja |
| 2               | Bot gestartet, benutzer auf discord.  | /remindme 5 "hello There" | (nach 5 sekunden) @user dont forget: hello there | Ja | 
| 3               | Bot gestartet, benutzer auf discord, tictactoe spiel 1 zug vom Gewinn entfernt  | /tictactoe {gewinnendes feld} | Player X/O has won. | Nein |

Heute habe ich zwei neue Befehle hinzugefügt. Für /remindme mit habe ich `await Task.Delay();` benutzt. Hierbei habe ich aber noch das Problem, das das die Befehlseingabe zu blockieren scheint. Obwohl discord.net dies eigentlich automatisch handeln soll. Vielleicht ist dies auch ein konfiguration- oder Verständnissfehler. Zudem habe ich bei /coinflip Random benutzt. Dies funktioniert gut, aber ich musste herausfinden, dass random.next(0,1) werte grösser oder gleich 0 nehmen kann, aber nicht bis und *mit* 1, sondern nur bis 1. Auch habe ich ein paar kleinere Verschönerungen hinzugefügt. Ich habe immer noch starke schwierigkeiten mit dem TicTacToe spiel, da ich das gefühl habe, das ich dafür Variabeln haben müsste, auf welche commands.cs und Program.cs zugreifen können.


## nächstes mal

- [ ] Verschönerungen
- [ ] Falls genug Zeit nach TicTacToe: Threading für /remindme
- [ ] TicTacToe spiel funktionalität bauen


| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1               | Bot gestartet, benutzer auf discord.  |  |  |  |
| 2               | Bot gestartet, benutzer auf discord.  |  |  |  |
| 3               | Bot gestartet, benutzer auf discord   |  |  |  |

Zusammenfassung

