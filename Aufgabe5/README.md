
## **Aufgabe: Multithreading mit Dateioperationen in C#**

### **Ziel der Aufgabe**

Erstellen Sie ein C#-Konsolenprogramm, das den Umgang mit Threads, Synchronisation und Dateioperationen demonstriert. Dabei sollen mehrere Threads gleichzeitig auf eine gemeinsame Datei zugreifen, wobei bestimmte Regeln eingehalten werden.

***

### **Anforderungen**

1.  **Datei öffnen**
    *   Beim Start des Programms wird eine Textdatei erstellt oder geöffnet (z. B. `data.txt`).

2.  **Schreibfunktion (`FileWrite`)**
    *   Schreibt jede Sekunde eine zufällige Textzeile in die Datei.
    *   Es sollen **3 Threads** gestartet werden, die diese Funktion ausführen.
    *   **Wichtig:** Es darf **immer nur ein Thread gleichzeitig schreiben**, und während des Schreibens darf **kein Lesen stattfinden**.

3.  **Lesefunktion (`FilePrint`)**
    *   Liest die Datei kontinuierlich und gibt **nur neue Zeilen** aus.
    *   Es sollen **2 Threads** gestartet werden, die diese Funktion ausführen.
    *   Mehrere Leser dürfen gleichzeitig lesen, aber **nicht**, wenn gerade geschrieben wird.

4.  **Synchronisation**
    *   Verwenden Sie einen geeigneten Mechanismus (z. B. `ReaderWriterLockSlim`), um sicherzustellen:
        *   Schreiben ist exklusiv.
        *   Lesen ist parallel möglich, aber nicht während des Schreibens.

5.  **Ausgabe**
    *   Jeder Thread soll in der Konsole anzeigen, was er gerade tut:
        *   Writer: „Writer-X hat geschrieben: …“
        *   Reader: „Reader-Y liest: …“

***

### **Zusatzaufgaben (optional)**

*   Implementieren Sie eine Möglichkeit, das Programm sauber zu beenden (z. B. mit `CancellationToken`).
*   Erstellen Sie eine Variante mit `async/await` und `Tasks` statt klassischen Threads.
*   Visualisieren Sie den Ablauf mit einem Diagramm (z. B. wie die Locks funktionieren).

***

### **Erwartetes Ergebnis**

*   In der Konsole sollen die Schreib- und Leseoperationen sichtbar sein.
*   Die Datei enthält fortlaufend neue Zeilen.
*   Die Synchronisation verhindert Datenkorruption und Race Conditions.

***
