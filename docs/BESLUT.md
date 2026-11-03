# Designbeslut

Här samlas designbesluten i Bunkerbyn, i stil med Architectural Decision Records. Ett designbeslut har inget facit, bara avvägningar. Därför skrivs alternativen och avvägningen ner, inte bara valet.

Begreppen följer kursen Problemlösning: [Designbeslut](https://mardby.se/w/index.php?title=Designbeslut) och [Introduktion till designmönster](https://mardby.se/w/index.php?title=Introduktion_till_designm%C3%B6nster).

## Mall

Kopiera mallen för varje nytt beslut. Numrera i ordning och ändra aldrig ett gammalt beslut. Om ett beslut ändras skrivs ett nytt som pekar på det gamla.

```
## B<nummer>: <kort rubrik>

Datum: ÅÅÅÅ-MM-DD
Issue: #<nummer>
Status: gällande | ersatt av B<nummer>

**Problemet:** Vad behöver lösas, och vilket värde ska lösningen ge?

**Signaler:** Vad i koden eller designen pekar på att det behövs något, till exempel en växande if-kedja eller samma val på flera ställen?

**Alternativ:**
1. <alternativ 1>: vad det ger och vad det kostar
2. <alternativ 2>: vad det ger och vad det kostar
3. Inget mönster alls: vad det ger och vad det kostar

**Val:** Vilket alternativ, och varför det väger tyngst här.

**När valet vore fel:** I vilket sammanhang ett annat alternativ hade varit bättre, eller när mönstret vore overkill.
```

## B1: Simuleringen skild från vyn

Datum: 2026-10-23
Issue: –
Status: gällande

**Problemet:** Spelet behöver en simulering som kan sparas, testas, köras för stationer man inte tittar på och kanske en dag delas i multiplayer.

**Signaler:** Stationer utanför skärmen ska leva vidare. Tester ska kunna köras utan att starta Godot.

**Alternativ:**
1. All logik i Godot-noder: snabbast att komma igång, men logiken går inte att testa utan Godot, och stationer utanför skärmen kräver noder som inte syns.
2. Simulering i vanlig C# och noder som bara visar den: logiken går att testa och spara, och flera stationer kan simuleras utan grafik. Kostar mer struktur, och data måste föras över från simuleringen till vyn.
3. Inget särskilt val: blandat efter vad som är bekvämt för stunden. Ger snabb start men en gräns som suddas ut och blir svår att dra i efterhand.

**Val:** Alternativ 2. Värdet ligger i att simuleringen är spelets kärna och ska leva länge. Kostnaden för gränsen är liten i början och svår att betala i efterhand.

**När valet vore fel:** I ett litet spel utan sparning, med en enda skärm och inget som händer utanför den, vore uppdelningen mer struktur än problemet är värt.
