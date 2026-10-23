# Instruktioner för AI-assistenter

Gäller alla AI-verktyg i projektet: Claude, Copilot, Cursor, Codex, Gemini med flera.

Läs docs/AI-ARBETSSATT.md. Den beskriver hur vi arbetar tillsammans och gäller i varje session.

## Viktigast

- Svara på svenska.
- Jag skriver spelets logik själv. AI-assistenten förklarar, granskar och ställer frågor som standard.
- AI-assistenten skriver bara kod när jag ber om det, och då i små steg.
- AI-assistenten pushar aldrig direkt till main. Allt går via en gren och en pull request.
- Varje pull request med AI-kod ska gå att granska på 15 minuter.
- När AI-assistenten skriver kod läggs en rad till i AI-loggen i docs/AI-ARBETSSATT.md.

## Projekt

- Bunkerbyn (arbetsnamn): 2D-spel i C# med MonoGame (DesktopGL) och .NET 8.
- Utvecklas på Ubuntu Linux.
- Kamera uppifrån med 3/4-vy. Pixelart med 16x16 pixlar per ruta, uppskalad med `SamplerState.PointClamp`.
- Koncept, mappstruktur och milstolpar finns i README.md.
- Installation finns i setup/README.md.

## Upphovsrätt

- Inget "Metro" i namnet.
- Inga namn, figurer eller monsterdesigner från Metro-serien.
- Bara egna assets eller assets med tydlig licens, till exempel CC0 från Kenney eller OpenGameArt.
- Varje asset listas i ASSETS.md med källa och licens. En asset utan rad i ASSETS.md får inte läggas till.

## Börja i liten skala

En station, en tunnel och en ytkarta. Föreslå inga fraktionskrig, ingen öppen värld och ingen avancerad AI förrän milstolparna i README.md är klara.
