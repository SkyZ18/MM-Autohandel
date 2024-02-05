## Installation und Setup
Als erstes sollte Docker Desktop installiert sein. Dies wird für die Datenbank benötigt.

Dazu diesem Link folgen:
https://desktop.docker.com/win/main/amd64/Docker%20Desktop%20Installer.exe?utm_source=docker&utm_medium=webreferral&utm_campaign=dd-smartbutton&utm_location=module

Die .exe soll ausgeführt werden und die benötigten Setup-Schritte abgeschlossen werden.

Als nächstes muss Docker Desktop gestartet werden. Ist dies bereits geschehen, so muss das Projekt: Autohaendler in Visual Studio geöffnet werden. Nach dem initialisieren wird im Terminal folgender Befehl ausgeführt: 

```
docker-compose up
```

Die Datenbank sollte nun automatisch in Docker angelegt werden. Am besten nochmal überprüfen ob der Port 5432:5432 ist.

Wenn alles stimmt kann die C#-Applikation gestartet werden.