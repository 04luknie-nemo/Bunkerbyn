# Instruktioner för AI-assistenter

Gäller alla AI-verktyg i projektet: Claude, Copilot, Cursor, Codex, Gemini med flera.

Läs docs/AI-ARBETSSATT.md. Den beskriver hur vi arbetar tillsammans och gäller i varje session.

## Viktigast

- Svara på svenska.
- Jag skriver kärnan själv: simuleringen och spelreglerna. AI-assistenten förklarar, granskar och ställer frågor som standard.
- Rörledningarna, som Godot-limmet, gränssnittets layout, shaders, CI och datafiler, får AI-assistenten skriva när jag ber om det. Se Kärna och rörledningar i docs/AI-ARBETSSATT.md.
- AI-assistenten skriver bara kod när jag ber om det, och då i små steg.
- AI-assistenten pushar aldrig direkt till main. Allt går via en gren och en pull request.
- Varje pull request med AI-kod ska gå att granska på 15 minuter.
- När AI-assistenten skriver kod läggs en rad till i AI-loggen i docs/AI-ARBETSSATT.md.

## Projekt

- Bunkerbyn (arbetsnamn): kolonisimulator med överlevnad i Stockholms tunnelbana, byggd i Godot 4 med C# och .NET 8.
- Utvecklas på Ubuntu Linux.
- Low poly 3D med runda figurer. Kamera i 3/4-vy som roterar fritt.
- Alla designbeslut finns i docs/DESIGN.md. Läs den innan du föreslår mekaniker.
- Koncept, mappstruktur och milstolpar finns i README.md.
- Installation finns i setup/README.md.

## Kod

- Simuleringen skrivs i vanlig C# under scripts/Simulation och känner inte till Godot. Godot-noder under scripts/View visar bara simuleringen.
- Simuleringen klarar flera stationer. Invånare, lager, el och moral hör till en `Station`. En `World` håller alla stationer och tunnelsträckor.
- Positioner i simuleringen är abstrakta: en station, eller en sträcka plus ett avstånd. Vägsökning, synlinjer, ljus och ljud räknas på simuleringens rutnät, inte med Godots fysik.
- Innehåll som föremål, byggnader, karaktärsdrag och lagar definieras som data, inte som `enum` eller hårdkodade klasser.
- Simuleringen tickar i fast takt (20 tick per sekund vid 1x), går att spara och tar all slump från en källa med frö.
- Objekt pekar på varandra med `int`-id, inte med referenser. Fält som pekar på något annat heter som objektet plus `Id`, till exempel `ResidentId` eller `HomeStationId`.
- Namn på klasser, metoder och variabler skrivs på engelska.
- Spelets texter skrivs på engelska och går genom Godots översättningssystem. Platsnamn är svenska.

## Upphovsrätt

- Inget "Metro" i namnet.
- Inga namn, figurer eller monsterdesigner från Metro-serien.
- Bara egna assets eller assets med tydlig licens, till exempel CC0 från Kenney, Quaternius eller OpenGameArt.
- Varje asset listas i ASSETS.md med källa och licens. En asset utan rad i ASSETS.md får inte läggas till.

## Börja i liten skala

En station, en tunnel och en ytkarta. Invånarnas behovsstyrda AI hör till kärnan och byggs tidigt. Nätkartan med grannstationer och expansion är spelets långsiktiga mål, men byggs först när milstolparna i README.md är klara. Föreslå ingen multiplayer innan dess.
