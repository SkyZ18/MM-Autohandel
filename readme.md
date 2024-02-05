## Installation und Setup
Als erstes sollte Docker Desktop installiert sein. Dies wird f�r die Datenbank ben�tigt.

Dazu diesem Link folgen:
https://desktop.docker.com/win/main/amd64/Docker%20Desktop%20Installer.exe?utm_source=docker&utm_medium=webreferral&utm_campaign=dd-smartbutton&utm_location=module

Die .exe soll ausgef�hrt werden und die ben�tigten Setup-Schritte abgeschlossen werden.

Als n�chstes muss Docker Desktop gestartet werden. Ist dies bereits geschehen, so muss das Projekt: Autohaendler in Visual Studio ge�ffnet werden. Nach dem initialisieren wird im Terminal folgender Befehl ausgef�hrt: 

```
docker-compose up
```

Die Datenbank sollte nun automatisch in Docker angelegt werden. Am besten nochmal �berpr�fen ob der Port 5432:5432 ist.

Wenn alles stimmt kann die C#-Applikation gestartet werden.