# Aufgabe 2

Es besteht eine Konsolenapplikation, welche die Anzahl aller `X` in eine große Textdatei ermittelt.

Da dies sehr langsam ist, soll dies mit Mehreren Threads erfolgen.

Die Methode `ProcessFilePart` ist schon vorbereitet, damit immer ein Teil der Zeilen eines Files durchsucht wird.

Jeder Thread soll maximal 100 Zeilen durchsuchen.
Thread 1 startet bei Zeile 100, Thread 2 bei Zeile 200, Thread 3 bei Zeile 300, usw.

Aufgabe:
- erstellen Sie die Threads 
- erstellen Sie eine Zählvariable 
- Ausgabe des Zählstandes im Sekundentakt.
- Identifizieren Sie, ob es zu einer Race-Condition kommen kann, und beheben Sie diese.
