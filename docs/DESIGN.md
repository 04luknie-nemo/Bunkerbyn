# Design

Det här dokumentet samlar besluten om Bunkerbyn. Ändra här när ett beslut ändras, så att README, AGENTS.md och koden följer samma källa.

Prototyper (privata länkar, öppnas med ditt konto):
- [Perrongen i två stilar, 2D](https://claude.ai/artifact/D3MP1qurYSuYxnLinT8mqt)
- [Perrongen i low poly 3D med gångstilar](https://claude.ai/artifact/EHdmaCbbZDXugDSBxkE4RS)

## Översikt

Bunkerbyn är en kolonisimulator med överlevnad i Stockholms tunnelbana, sju år efter ett kärnvapenkrig. Du styr en station med invånare som har behov, roller och moral. På stationen ger du order. I tunnlarna och på ytan styr du en utvald invånare direkt.

Närmaste förebilder:
- This War of Mine: skyddsrum, räder och permanent död.
- RimWorld och Oxygen Not Included: invånare som arbetar själva efter behov.
- Frostpunk: moral, ledarskap och uppror.
- Going Medieval och Timberborn: low poly 3D med roterbar kamera.

## Värld

- Stockholm, sju år efter ett kärnvapenkrig.
- Bomberna slog ner mot militära mål runt staden, till exempel Muskö, Berga och Arlanda. City träffades inte direkt, så de djupa stationerna i berg klarade sig.
- Ytan är farlig av flera skäl: kyla efter atomvintern, rök, förorenat vatten, platser med kvarvarande strålning, muterade djur och desperata människor.
- Gasmasken skyddar mot rök, damm och förorenad luft. Den skyddar inte mot strålning.
- Inget övernaturligt. Mutationer och faror ska gå att förklara.
- Verkliga stationsnamn och platser används. Inget från Metro-serien, se AGENTS.md.

## Startstation: Kungsträdgården

- Ändstation på blå linjen. Tunnlarna går bara åt ett håll, så faran kommer från ett håll.
- Bergrum med väggar målade i grönt, rött och vitt.
- Namnet betyder kungens trädgård och passar en station som odlar.
- Blå linjens förlängning mot Nacka och Söderort lämnar halvfärdiga tunnlar att utforska senare.
- Ovanför ligger parken Kungsträdgården, slottet och Gamla stan.

## Start och introduktion

- Du är en ny ankomst. En grupp från stationen hittade dig skadad i tunneln.
- Gruppen var ute för att hämta diesel. De valde att bära dig i stället för dunkarna.
- Generatorn har bränsle för ungefär fem dagar. Sedan slocknar lysrören, svampen slutar växa, pumparna stannar och vattnet stiger.
- Vissa invånare tycker att du var fel val. Du börjar med en skuld.
- **Nadia**, sjuksköterska i 30-årsåldern, räddade dig och sköter din läkning. Hon överlever introduktionen. Hennes regel att rädda alla krockar med stationens överlevnad.
- Du ligger skadad först och lär dig ge order från britsen. När du kan gå lär du dig styra direkt, och första uppdraget blir att hämta dunkarna som lämnades kvar.
- Läkningen ska ta 10 till 15 minuter i verklig tid, inte längre.
- Stationen har 15 invånare när du kommer.
- Introduktionen byggs först. Fler startscenarier kodas senare och väljs i menyn.

## Styrning och kamera

- **Kamera:** 3/4-vy uppifrån som roterar, lutar och zoomar fritt. Väggar mellan kameran och stationen döljs.
- **På stationen:** Du markerar och ger order. Invånarna sköter behov och arbete själva.
- **I tunnlarna och på ytan:** Du styr en utvald vuxen invånare direkt.
- **Indata:** Tangentbord och mus. Handkontroll stöds.
- **Spelhastighet:** Paus, 1x, 2x och 3x.

## Tid

- En speldag är 20 minuter i verklig tid vid 1x.
- Stationen fortsätter leva medan du är ute i tunnlarna.
- Svampen skördas efter tre dagar, alltså en timme i verklig tid.
- Bränslet i introduktionen räcker fem dagar, cirka 100 minuter. Det ger press under första spelomgången utan att stressa.

Siffrorna är startvärden och justeras när spelet går att testa.

## Invånare

**Befolkning**

| Nivå | Antal | Hur det simuleras |
|---|---|---|
| Din station i början | 15 | Varje person fullt |
| Din station utbyggd | 100 till 200 | Fullt, förenklat utanför skärmen |
| Grannstationer | Hundratals var | En siffra plus några ledare |
| Hela tunnelbanan | 5 000 till 20 000 | En siffra i lore och handel |

Bygg för 50 invånare först och optimera mot 200 senare.

**Behov:** mat, vatten, sömn, värme och luft.

**Karaktärsdrag**
- Färdigheter 0 till 10: odling, mekanik, medicin, matlagning, strid och förhandling. Två till tre höga per person.
- Personlighet: ett till två drag, till exempel modig, feg, girig, omtänksam, hetsig eller lugn.
- Bakgrund: en rad om livet före kriget. Ger ingen bonus.

**Ålder**
- Barn och äldre bor på stationen.
- Bara vuxna går ut i tunnlarna. Barn skickas aldrig ut.
- Barn kan dö av sjukdom, kyla, svält eller olyckor. Döden visas utanför bild. Spelaren kan aldrig skada barn direkt.
- Barn växer upp och blir vuxna med tiden.

**AI:** Varje invånare väljer handling efter poäng (utility AI). Hunger ger "äta" högt värde, trötthet ger "sova" högt värde, rollen ger arbete högt värde under arbetstid. Varje handling är en klass som räknar fram sin poäng.

**Gångstil:** Steglängd, armsving, lutning, huvud, takt och hastighet räknas fram från behov och tillstånd. Trött, hungrig, skadad, rädd och bärande syns i kroppen. Se prototypen i 3D.

## Ledarskap och moral

- Stationen har en chef. Dina order går genom chefen.
- Hög auktoritet: order utförs direkt. Låg auktoritet: order går långsamt eller ignoreras.
- Du kan väljas till chef. Order går då direkt, men moralen sjunker varje dag du är ute i tunnlarna, och dör du där faller den kraftigt.
- När chefen dör röstar invånarna efter relationer, personlighet och vad kandidaterna har gjort. Du kan påverka genom att prata med folk.
- Ingen majoritet: du kan ta makten (snabbt, men moralen sjunker och fiender uppstår) eller bilda ett råd på tre (stabilt, men order går långsammare). Rådet byggs efter val och maktövertagande.
- Uppror växer fram ur poängen: låg moral och svag chef ger en invånare höga poäng för att ta över.
- Att dela stationen i två sparas till ett senare scenario.

## Resurser

**El**
- Generatorer går på diesel från ytan och tunnlarna.
- Du kan stänga av delar av stationen för att spara bränsle.
- Utan el stannar lysrör, odling, pumpar och fläktar.
- Facklor och lägereldar ger ljus utan el, men förbrukar syre och ger rök.

**Luft**
- Fläktar drar in luft från ytan genom filter.
- Utan el stannar fläktarna. Då krävs handpumpar eller öppna schakt, som släpper in faror.

**Vatten**
- Grundvatten läcker in i tunnlarna. Det samlas, filtreras genom sand och kol och kokas.
- Om pumparna stannar svämmar tunnlarna över.
- Senare: kondens från ventilationen, regn och snö från ytan, gamla tankar i byggnader.

**Mat:** Svamp och rotfrukter under lysrör, senare djur.

**Lager:** Har ett tak och kan bli fullt.

## Död

- Döden är permanent. Du väljer en ny invånare ur stationens pool.
- Kroppen ligger kvar med sina saker och går att hämta, utom i stup du inte når.
- Bytet ska kännas:
  - Den nya karaktären har en relation till den döda, och sorgen eller lättnaden påverkar den.
  - Den dödas kunskap om kartor, recept och kontakter går förlorad, utom det som står i dagboken.
  - Dagboken följer med kroppen. Den som hittar kroppen får kunskapen tillbaka.
  - En begravning kostar en dag men höjer moralen.
- Om alla dör är spelet förlorat.
- Spelet sparar automatiskt varje morgon. Du kan inte ladda om för att ångra en död.

## Mål

Spelet är oändligt. Tre spår ger riktning:

1. **Överleva:** Klara bränslekrisen i introduktionen, sedan vinter, sjukdomar och översvämningar.
2. **Bygga upp:** Stationen växer i nivåer. Exempel: fungerande el, renat vatten, filtrerad luft, ett öppnat stängt schakt och en säker utgång till parken ovanför.
3. **Upptäcka:** En berättelse om omvärlden. Exempel: en trasig radio, signaler från andra stationer, en expedition till T-Centralen, och rykten om att någon lever kvar vid Muskö.

Ett långsiktigt mål som passar oändlig speltid: att stationen överlever en generation, så att barnen som föddes på stationen blir dess vuxna.

## Grafik

- Low poly 3D med runda figurer, platt skuggning och få eller inga texturer.
- Figurer byggs av lager: kropp, huvud, hår och kläder, för många varianter.
- Animationer: ett skelett för alla, cirka tio grundanimationer, gångstil som blandas fram efter tillstånd.
- Ljuset är en del av spelet: lysrör, facklor, lägereld och ficklampa med skuggor.

## Teknik

- Godot 4 med C# och .NET 8.
- Blender för modeller, exporterade som `.glb`.
- Simuleringen är vanlig C# utan Godot-noder. Godot-noderna visar bara simuleringen. Det gör logiken testbar och multiplayer möjligt senare.

## Språk

- Spelets texter skrivs på engelska.
- Platsnamn är svenska: T-Centralen, Slussen, Kungsträdgården.
- Svenska ord som skyddsrum, fika och pant används där sammanhanget förklarar dem.
- Typsnittet måste ha å, ä och ö.

## Öppna frågor

- **Valuta:** Ammunition som i första idén, eller byteshandel?
- **Mutanter:** Förslag i början: råttor, hundar och grottspindeln från Kungsträdgården. Muterade människor senare?
- **Ton:** Svält och barn som dör är bestämt. Självmord, tortyr och kannibalism är inte bestämt.
- **Namn:** Bunkerbyn är arbetsnamn. Ett engelskt namn kan behövas för Steam.
- **Ljud och musik.**
- **Plattformar och pris.**
- **Multiplayer:** Flera stationer, kanske samma station. Väntar tills enspelarläget fungerar.
- **Grannstationer och fraktioner:** Efter milstolparna.
