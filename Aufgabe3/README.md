# Producer/Consumer

Es besteht eine Application mit einem Producer `TextProducer`, welcher Strings produziert und einem Consumer `TextConsumer`. 

Leider ist dieses Programm nicht fertig. Ihre Aufgabe ist es dies fertig zu stellen mit folgen Aufgaben:


* Erstellen Sie eine Queue 
* Erstellen und starten Sie in `Main`:
  * 2 Producer-Threads (Writer), welche jeweils die Methode `TextProducer` starten.  
  * 1 Consumer-Thread (Reader), welcher die Methode `TextConsumer` startet. 
* Erweitern Sie `TextProducer`, damit dieser pro Sekunde einen Eintrag (random String) in die Queue schreibt.
* Erweitern Sie `TextConsumer`, damit der kontinuierlich ( alle 200ms) aus der Queue liest und in der Konsole ausgibt.
* Vermeiden Sie eine Race Condition!
