# Arbetssätt med AI

Det här dokumentet beskriver hur jag använder AI-assistenter i projektet. Det gäller oavsett verktyg: Claude, Copilot, Cursor, ChatGPT eller något annat. Målet är att jag ska kunna förklara varje rad i koden. Om jag inte kan det har AI:n gjort för mycket.

## Roller

| Jag                                    | AI-assistenten                                                  |
| -------------------------------------- | --------------------------------------------------------------- |
| Skriver scener, simulering och logik   | Förklarar mönster och begrepp innan jag skriver                 |
| Bestämmer struktur, namn och spelregler | Granskar min kod och pekar på problem                           |
| Granskar och godkänner all kod från AI:n | Föreslår kantfall jag missat                                    |
|                                        | Skriver boilerplate när jag ber om det: konfiguration, CI, setup |

## Tre nivåer av hjälp

Jag väljer nivå för varje uppgift och säger det i början.

1. Förklara. AI:n förklarar utan att skriva lösningen. Korta exempel på ett mönster är okej.
2. Granska. Jag skriver koden. AI:n kommenterar men skriver inte om den.
3. Ta över. AI:n skriver koden. Jag granskar den enligt checklistan nedan innan den mergas.

Nivå 1 och 2 är standard. Nivå 3 använder jag för kod jag redan förstår, eller när jag vill se ett förslag att jämföra med.

## Kärna och rörledningar

Koden delas i två högar. Kärnan är där jag lär mig mest och där spelet blir mitt. Rörledningarna är mycket kod som lär mig lite, och där ger AI mest fart.

| Kärnan: jag skriver | Rörledningar: AI skriver, jag granskar |
|---|---|
| Simuleringen: rutnät, A*, behov, utility AI, klocka, val | Godot-limmet: noder som ritar simuleringen och kopplar signaler |
| Spelregler: odling, lager, moral, kontroll | Gränssnittets layout: paneler, knappar, larm |
| Allt jag ska kunna förklara på en intervju | Shaders, ljus och kamerafinlir |
| | CI, sparning till JSON, PO-filer, inställningar |
| | Datafiler: varor, karaktärsdrag, namn, utkast till dialog |

- I kärnan är nivå 1 och 2 standard. AI:n skriver inte kärnkod om jag inte uttryckligen ber om det.
- I rörledningarna får AI:n ta över (nivå 3) när jag ber om det.
- Har jag skrivit något i kärnan en gång själv får AI:n skriva liknande kod nästa gång.

## Arbetsflöde per issue

1. **Planera:** AI:n förklarar utan kod hur issuen kan lösas. Cirka 10 minuter.
2. **Testfall:** AI:n föreslår testfall för det som ska byggas. Jag skriver koden tills testerna går igenom.
3. **Skriva:** Jag skriver kärnan. Sitter jag fast i 15 minuter frågar jag direkt.
4. **Granska:** AI:n granskar pull requesten med kommentarer på raderna.
5. **Rörledningar:** När kärnan fungerar skriver AI:n vyn, gränssnittet och limmet. Jag granskar.

**Felsökning:** "Säg vad som är fel" när jag vill vidare. "Ställ frågor tills jag ser felet" när jag vill lära mig.

**Tumregel:** Om jag kan förklara varje rad är koden min, oavsett vem som skrev den.

## Arbeta i små etapper

En etapp är en sak, till exempel "gubben går en ruta åt gången". Varje etapp följer samma steg:

1. Jag beskriver vad som ska byggas.
2. AI:n ställer frågor om regler och kantfall.
3. Koden skrivs, av mig eller av AI:n beroende på nivå.
4. Koden hamnar på en egen gren och i en pull request.
5. Jag granskar varje fil.
6. Bygget och formateringen går igenom i GitHub Actions.
7. Merge till main.

En etapp ska gå att granska på cirka 15 minuter. Blir den större delar jag upp den.

## När AI:n tar över

- Koden hamnar på en egen gren, aldrig direkt mot main.
- Pull requesten beskriver vad som ändrats och varför, och att AI skrev koden.
- Jag granskar varje fil innan merge.
- En rad läggs till i AI-loggen nedan, med PR-numret. Kan verktyget inte skriva i repot, lägger jag till raden själv.

## Verktyg och instruktionsfiler

Reglerna för AI-assistenter står i AGENTS.md i roten. Olika verktyg hittar dem på olika sätt:

| Verktyg                                    | Läser                                       |
| ------------------------------------------ | ------------------------------------------- |
| Claude Code                                | CLAUDE.md, som pekar på AGENTS.md           |
| GitHub Copilot, Cursor, Codex              | AGENTS.md                                   |
| Gemini CLI                                 | GEMINI.md, eller AGENTS.md om det ställs in |
| ChatGPT, Claude eller Gemini i webbläsaren | Ingenting i repot                           |

Använder du en webbchatt: klistra in innehållet i AGENTS.md i början av chatten, och lägg själv till raden i AI-loggen.

Ändra reglerna i AGENTS.md, inte i CLAUDE.md. Då gäller de för alla verktyg.

## Checklista vid granskning av AI-kod

- [ ] Jag kan förklara vad varje rad gör.
- [ ] Jag kan förklara varför lösningen ser ut så här, och inte på ett annat sätt.
- [ ] Koden följer mappstrukturen i README.md. Simuleringen använder inga Godot-typer.
- [ ] Inga nya NuGet-paket har lagts till utan att jag vet varför.
- [ ] Nya assets finns i ASSETS.md med källa och licens.
- [ ] Bygget och formateringen går igenom i GitHub Actions.

Om en punkt inte stämmer frågar jag AI:n tills den gör det, eller skriver om koden själv.

## Bra frågor att ställa

- "Förklara utan kod hur jag borde lösa X."
- "Visa ett kort exempel på mönstret, inte min lösning."
- "Granska min kod, peka på problem men skriv inte om den."
- "Ställ frågor tills jag själv ser felet."
- "Vilka kantfall saknas?"

## AI-logg

Här loggas varje gång en AI-assistent skriver kod som hamnar i repot. Kolumnen PR länkar till pull requesten där koden granskades.

| Datum      | Etapp        | Verktyg     | Nivå    | Vad AI:n gjorde                                                                                                                                         | PR  |
| ---------- | ------------ | ----------- | ------- | ------------------------------------------------------------------------------------------------------------------------------------------------------- | --- |
| 2026-10-23 | Projektstart | Claude Code | Ta över | Skrev README, CLAUDE.md, AGENTS.md, ASSETS.md, det här dokumentet, setup/README.md, .editorconfig, .gitignore, .vscode och build.yml med Household som förebild | –   |
| 2026-10-23 | Designbeslut | Claude Code | Ta över | Skrev docs/DESIGN.md efter grillningen. Bytte MonoGame och pixelart mot Godot 4 och low poly 3D i README, AGENTS.md, setup/README.md och .gitignore. Byggde två prototyper i webbläsaren, i 2D och i 3D, som inte ligger i repot | –   |
| 2026-10-23 | Valuta och djur | Claude Code | Ta över | Lade till tändstickor som valuta i tre nivåer och svenska djur som faror i docs/DESIGN.md | #1  |
| 2026-10-23 | De brända | Claude Code | Ta över | Lade till människor utanför stationerna, de brända och de förvildade, i docs/DESIGN.md | #1  |
| 2026-10-26 | Nätkartan | Claude Code | Ta över | Lade till nätkartan som långsiktigt mål och regeln om flera stationer i docs/DESIGN.md, AGENTS.md och README | –   |
| 2026-10-26 | Strid och barrikader | Claude Code | Ta över | Lade till strid i stationsvyn, barrikader, naturliga skydd och länk till den handritade nätkartan i docs/DESIGN.md | #12 |
| 2026-10-26 | Tunnlar och kontroll | Claude Code | Ta över | Lade till tunnlarna, levande världen, ljus och synfält, stationens kunskap, ljud, murar i lager och kontroll över sträckor och stationer i docs/DESIGN.md. Strukturregler i AGENTS.md och README | –   |
| 2026-10-26 | Samhälle och ekonomi | Claude Code | Ta över | Lade till val, lagar, föreståndare, resurser, ekonomi, handel, relationer, barn, sjukdom, ton och gränssnitt i docs/DESIGN.md efter Lukas val. Regeln om innehåll som data i AGENTS.md | –   |
| 2026-10-26 | Forskning | Claude Code | Ta över | Lade till forskning med böcker, bibliotek och forskningsträd, och längre kedjor senare, i docs/DESIGN.md | #14 |
| 2026-10-26 | Bygga och ta isär | Claude Code | Ta över | Lade till byggande med ritningar, att ta isär stationen till material, dressin och rälsport, och lager per ruta i docs/DESIGN.md | #14 |
| 2026-10-26 | Tekniska grundregler | Claude Code | Ta över | Lade till fast takt, sparbar simulering, slumpkälla med frö och texter via översättningssystemet i docs/DESIGN.md och AGENTS.md | #14 |
| 2026-10-26 | Teknikval | Claude Code | Ta över | Skrev in valen om 20 tick per sekund, id som int, egen slumpgenerator och PO-filer i docs/DESIGN.md | –   |
| 2026-10-28 | Kärna och rörledningar | Claude Code | Ta över | Lade till uppdelningen i kärna och rörledningar och arbetsflödet per issue i det här dokumentet och AGENTS.md | –   |
| 2026-10-28 | .NET 10 | Claude Code | Ta över | Bytte .NET 8 mot .NET 10 i README, AGENTS.md, DESIGN.md, setup/README.md och build.yml, eftersom Ubuntu 26.04 bara har .NET 10 i apt och .NET 8 slutar få stöd i november 2026 | –   |
