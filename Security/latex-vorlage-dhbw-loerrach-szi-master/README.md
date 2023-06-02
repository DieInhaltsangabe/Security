# Vorlage für das wissenschaftliche Arbeiten am SZI der DHBW Lörrach
## Vorbereitungen
> Die folgende Schritte zeigen das Vorgehen für Windows

1. MiKTeX downloaden und installieren: https://miktex.org/download
2. Texmaker downloaden und installieren: http://www.xm1math.net/texmaker/download.html
3. In Texmaker auf "Optionen -> Texmaker konfigurieren -> Schnelles Übersetzten" klicken
4. Die Option "Benutzerdefiniert" auswählen und folgenden Code einfügen: <br> ```lualatex -interaction=nonstopmode %.tex|biber %|lualatex -interaction=nonstopmode %.tex|lualatex -interaction=nonstopmode %.tex```
5. In der Konfigurtion lässt sich unter dem Punkt "Editor" eine Rechtschreibprüfung auswählen. Hier sollte man das deutsche Wörterbuch auswählen (de_DE.dic)
6. Mit "OK" die Konfiguration speichern.
7. Die Vorlage mit Git oder als [ZIP-Datei](https://gitlab.com/spitzerd/latex-vorlage-dhbw-loerrach-szi/-/archive/master/latex-vorlage-dhbw-loerrach-szi-master.zip) herunterladen
8. Die Datei document.tex mit Texmaker öffnen
9. Mit einem Klick auf den Pfeil links neben "Schnelles Übersetzen" wird nach etwa 10 Sekunden ein PDF-Dokument erzeugt. Beim ersten Mal dauert es länger, weil Pakete heruntergeladen werden müssen.

## Allgemeines zum Arbeiten mit der Vorlage
Alle für den Benutzer relevanten Dateien sind in dem Order text und im Wurzelverzeichnis. 
Die Datei document.tex ist die Masterdatei der Vorlage. Mit einem Klick auf "Optionen" kann man die aktuelle Masterdatei festlegen. Die Masterdatei muss die Datei document.tex sein. Durch die Option kann man das PDF-Dokument erzeugen, auch wenn man gerade nicht die Masterdatei offen hat.

Damit man das Öffnen der ganzen Dateien und die Definition der Masterdatei nicht bei jedem Start von Texmaker erledigen muss, kann man unter "Datei -> Sitzung" eine Sitzung speichern und sie wieder laden.

Bevor man mit dem Schreiben anfängt, sollte man die Datei config.tex anpassen. Dort sind Variablen für den Titel, den Autor usw. hinterlegt.

Auch ohne LaTeX-Kennnisse ist die Einarbeitungszeit gering, weil fast alle relevanten Befehle in der Vorlage als Beispiel im ersten Kapitel hinterlegt sind.

## Weiterführende Anleitungen
- Ausführliches Nachschlagewerk: https://en.wikibooks.org/wiki/LaTeX
- LaTeX-Spickzettel: https://www.uni-frankfurt.de/53485609/latexsheet.pdf

Weitere Anleitungen sind in der Datei [manuals.md](https://gitlab.com/spitzerd/latex-vorlage-dhbw-loerrach-szi/blob/master/manuals.md).
Folgende Abschnitte gibt es momentan:
- Schreiben mit Visual Studio Code
- Hinzufügen von weiteren Quellenarten
- Linux

## Ordnerstruktur
```
.
├── LICENSE.txt                 # Die Lizenz dieser Vorlage
├── README.md                   # Diese Datei
├── manuals.md                  # Weitere Anleitungen
├── images
│   └── dhbw_logo.pdf           # Das Logo der DHBW für das Deckblatt
│   └── company_logo.pdf        # Ein Beispiellogo für das Ausbildungsunternehmen
├── text                        
│   ├── abstract.tex            # Kurzfassung
│   ├── acronym.tex             # Abkürzungsverzeichnis
│   ├── appendix.tex            # Anhang
│   ├── bibliography.bib        # Datei mit den Literaturdaten
│   ├── chapter1.tex            # Kapitel 1
│   ├── chapter2.tex            # Kapitel 2
│   ├── chapter3.tex            # Kapitel 3
│   ├── chapter4.tex            # Kapitel 4
│   ├── chapter5.tex            # Kapitel 5          
│   └── template                # Vorlagenorder. Diese Dateien müssen nicht geöffnet oder geändert werden.
│       ├── declaration.tex     # Ehrenwörtliche Erklärung und Hinweis auf dem Umfang der Arbeit
│       ├── preamble.tex        # Globale Einstellungen
│       ├── references.tex      # Quellenverzeichnis
│       ├── releaseNotice.tex   # Freigabe der Arbeit
│       └── titlepage.tex       # Deckblatt
├── config.tex                  # Konfigurationsdatei für den Benutzer
└── document.tex                # Masterdatei
```
## Weiterentwicklung
Merge Requests und Issues sind gerne gesehen.

## Verwendete Logos/Marken
Das im Repository enthaltene Logo der Dualen Hochschule Baden-Württemberg (DHBW) ist gegebenenfalls durch Dritte, wie zum Beispiel die DHBW, geschützt. Das Logo im Repository dient ausschließlich der Erfüllung der Vorgaben der DHBW für das wissenschaftliche Arbeiten. Diese LaTeX-Vorlage wurde nicht im Auftrag der DHBW erstellt. Die Verwendung des Logos drückt keine Unterstützung der DHBW für diese LaTeX-Vorlage aus. 

