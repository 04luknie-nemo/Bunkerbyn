# Design

Det här dokumentet samlar besluten om Bunkerbyn. Ändra här när ett beslut ändras, så att README, AGENTS.md och koden följer samma källa.

Prototyper (privata länkar, öppnas med ditt konto):
- [Perrongen i två stilar, 2D](https://claude.ai/artifact/D3MP1qurYSuYxnLinT8mqt)
- [Perrongen i low poly 3D med gångstilar](https://claude.ai/artifact/EHdmaCbbZDXugDSBxkE4RS)
- [Stockholm under jord, handritad nätkarta](https://claude.ai/artifact/6mZ9QdgXzEsNQ4ac9oziQ5)

## Översikt

Bunkerbyn är en kolonisimulator med överlevnad i Stockholms tunnelbana, sju år efter ett kärnvapenkrig. Du styr en station med invånare som har behov, roller och moral. På stationen ger du order. I tunnlarna och på ytan styr du en utvald invånare direkt.

Det långsiktiga målet är att växa utåt: ta tunnelsträckor, bygga utposter och vinna grannstationer, tills din station är en makt i tunnelnätet.

Närmaste förebilder:
- This War of Mine: skyddsrum, räder och permanent död.
- RimWorld och Oxygen Not Included: invånare som arbetar själva efter behov.
- Frostpunk: moral, ledarskap och uppror.
- Going Medieval och Timberborn: low poly 3D med roterbar kamera.
- Hearts of Iron IV och Metro-modden: en strategikarta där du växer utåt.

Inget färdigt spel gör detta bra. Metro 2033: Wars hade idén om att ta station efter station men fick dålig kritik. Until We Die handlar om att försvara en station, inte att växa.

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

**Relationer och barn**
- Invånare har relationer till varandra: vänskap, kärlek, ovänskap. De växer av tid tillsammans och delade händelser.
- Par kan bildas och barn kan födas. Befolkningen växer inifrån, inte bara genom flyktingar och räddade.
- En skola på stationen ger barnen färdigheter innan de blir vuxna.
- En graviditet och ett spädbarn kostar mat och arbetstid, men ger stationen en framtid. Det knyter an till målet att överleva en generation.

**Sjukdom**
- Smitta sprids i trånga utrymmen, genom dåligt vatten och genom mat från råttor.
- Sjuka arbetar sämre och kan smitta andra.
- Karantän och medicin stoppar spridningen. Medicin kommer från ytan och sjukhus.

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

**Val**
- Chefen väljs genom röstning bland de vuxna.
- Varje vuxen ger varje kandidat poäng: relation, om personligheterna passar ihop, vad kandidaten har gjort och vad den lovar. Rösten går till den med högst poäng. Det är samma utility AI som för behoven.
- Du påverkar genom att prata med folk, ge gåvor och lova lagar. Ett brutet löfte sänker förtroendet för den som lovade.
- Val hålls när chefen dör, när förtroendet för chefen faller under en gräns, eller när en majoritet kräver det.

**Lagar**
Chefen beslutar lagar. Varje lag gillas av vissa personligheter och ogillas av andra, så moralen påverkas olika för olika invånare.

| Område | Val |
|---|---|
| Ransoner | Lika för alla, eller mer till de som arbetar |
| Vem går ut | Frivilliga, lottning eller order |
| Flyktingar | Ta in alla, bara arbetsföra, eller ingen |
| Straff | Arrest, arbete, utvisning eller avrättning |
| De döda | Begravning, eller kremering som sparar tid |
| Arbetstid | Normal, eller förlängd i kris |

- En lag kan inte ändras hur ofta som helst. Att byta lag kostar förtroende.
- Grupper uppstår av sig själva bland dem som tycker lika. De som håller med Nadia om att rädda alla samlas, och de hårda samlas på andra sidan. Grupperna bestäms inte i förväg.

**Stationer du har tagit över**
- Du utser en föreståndare: en av dina invånare eller en lokal ledare. Föreståndaren har lojalitet, skicklighet, ambition och personlighet.
- Du ger riktlinjer, inte order:
  - Fokus: mat, försvar, handel eller tillväxt.
  - Tribut: hur stor del av produktionen som skickas hem.
  - Lagar: dina, eller stationens egna.
- Föreståndaren styr själv med samma utility AI som invånarna, fast på stationsnivå. Ökar hotet bygger hen mur. Tar maten slut skickar hen expeditioner.
- Stationen simuleras förenklat när du inte tittar: produktionen räknas fram ur befolkning, byggnader och föreståndarens skicklighet.
- Rapporter tar tid. En budbärare går på nätet med nyheter. Det du vet kan vara dagar gammalt, och budbärare kan dö på vägen.
- Riskerna:
  - Hög tribut ger låg moral och risk för uppror.
  - En föreståndare med hög ambition och låg lojalitet kan bryta sig loss.
  - En girig föreståndare kan behålla en del av tributen.
- Du kan gå ner i stationen och styra den direkt en tid.

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

**Alla resurser**

| Grupp | Exempel |
|---|---|
| Grundbehov | Mat, vatten, luft, värme |
| Energi | Diesel, batterier |
| Material | Stål, betong, sliprar, gummi, isolering, skrot, elektronik |
| Medicin | Förband, antibiotika, jodtabletter |
| Utrustning | Gasmasker, filter, lampor, verktyg, vapen, ammunition |
| Lyx | Kaffe, snus, sprit, böcker |
| Kunskap | Kartor, recept, dagböcker |

**Förbrukning:** Varje person förbrukar en portion mat och tre liter vatten per dag. Det gör det lätt att se hur länge lagret räcker. Värdena justeras när spelet går att testa.

## Ekonomi

- **Korta kedjor**, högst två steg: svamp blir mat, läckvatten filtreras och kokas, skrot blir delar och delar blir verktyg.
- **Verkstäder** gör förädlingen: kök, vattenrening, verkstad, sjukstuga. Varje verkstad kräver en invånare med rätt färdighet.
- **Priser varierar mellan stationer.** En station med mycket vatten betalar lite för vatten. Priset räknas fram ur hur mycket stationen har och hur mycket den behöver.
- **Tändstickorna tar slut med tiden**, så valutan blir värd mer. Det passar en värld som långsamt tömmer sina lager.

**Handel**
- Varor flyttas med karavaner som går på nätet. Det tar tid, och karavaner kan rånas.
- Du kan skicka egna karavaner, och andra stationers karavaner kommer till dig.
- En säker handelsväg kräver hävdade eller säkrade sträckor. Det knyter handeln till kontrollen på nätkartan.

## Valuta

Ammunition som valuta är Metros mest kända idé och används inte. Bunkerbyn har en svensk valuta i tre nivåer:

| Nivå | Valuta | Används till |
|---|---|---|
| Vardag | Tändstickor | Mat, små tjänster, information |
| Lyx | Kaffe och snus | Moral, mutor, att få folk att lyssna |
| Stora affärer | Jodtabletter och gasmaskfilter | Handel mellan stationer, medicin, vapen |

- Säkerhetständstickan är en svensk uppfinning och massproducerades i Jönköping.
- Tändstickor förbrukas. Varje tändsticka du betalar med är en eld du inte tänder. Valet mellan att spara och att tända en fackla blir ett verkligt beslut.
- Kaffe växer inte i Sverige, så lagret tar slut för alltid. Fika höjer moralen.
- Snus torkar och tappar värde om det sparas för länge.
- Jodtabletter skyddar sköldkörteln mot radioaktivt jod och har högst värde.
- Kontanter är värdelösa. Sverige var nästan kontantfritt före kriget, och sedlar används som tändpapper.

## Djur och mutationer

Alla faror är djur som finns i Sverige. Mutationerna är realistiska efter sju år: djuren har anpassat sig till mörker, strålning och brist på mat. De är inte jättemonster.

Exempel på mutationer: blekare päls eller ingen päls, svaga ögon men bättre hörsel, tumörer, större flockar, mer aggressiva, bärare av sjukdomar.

**I tunnlarna**
- **Brunråttor:** Svärmar i mörkret. Sprider sjukdom och äter av lagret. Första faran i spelet.
- **Fladdermöss:** Bor i tunnlarna och reagerar på ljus och ljud. Kan sprida sjukdom.
- **Förvildade hundar:** Flockar som har tagit sig ner från ytan.
- **Mink:** Förvildad mink från gamla pälsfarmer, i översvämmade tunnlar.
- **Grottspindeln på Kungsträdgården:** Uppges bara finnas på den stationen i Sverige. Ofarlig, men en del av stationens lore.

**På ytan**
- **Vildsvin:** Stora, starka och aggressiva. Den farligaste vanliga faran på ytan.
- **Älg:** Sällsynt i staden men livsfarlig när den är sjuk eller skrämd.
- **Gråtrutar och kajor:** Attackerar i flock och stjäl mat.
- **Rävar:** Smarta, rör sig ensamma och plundrar förråd.
- **Varg och lodjur:** Senare, i utkanten av staden.

**I vattnet**
- **Signalkräftor:** Matkälla i översvämmade tunnlar.
- **Gäddor:** Stora och farliga i djupt vatten.

Djuren är också resurser. Råttor, duvor och kräftor kan bli mat när annat tar slut, med risk för sjukdom.

## Människor utanför stationerna

Det finns inga zombies och inga odödliga ghouls. Hög strålning dödar inom dagar eller veckor, och lägre doser ger cancer och kortare liv.

**De brända**
- Människor som överlevde strålning men fick bestående skador: ärr från brännskador, håravfall, fläckig hud och grå starr.
- Svagt immunförsvar och kortare liv. De är inte starkare och inte immuna.
- Stationerna stöter bort dem av rädsla för smitta, fast strålningsskador inte smittar. De bor på förorenade platser där ingen annan vill vara.
- De känner ytan efter sju år där och vet var strålningen är farlig. De handlar med saker från ytan.
- Att ta in en av dem sänker moralen hos vissa invånare och höjer den hos andra, beroende på personlighet.
- Förebilder: hibakusha i Japan, som mötte fördomar i decennier, och samosely, som flyttade tillbaka in i zonen runt Tjernobyl. Ämnet behandlas med respekt.

**De förvildade**
- Människor som har förvildats av svält, isolering och mörker i åratal.
- Desperata och oberäkneliga, men fortfarande människor.
- De rånar karavaner och anfaller svaga utposter.

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

## Nätkartan

Spelet har två lager:

1. **Stationsvyn:** Kolonin i 3D med invånare, behov och ledarskap. Allt i avsnitten ovan.
2. **Nätkartan:** Stockholms tunnelbana som strategikarta, ungefär som kartan i Hearts of Iron IV.

**På nätkartan**
- Stationer och tunnelsträckor är noder och kanter. Varje sträcka har ett tillstånd: okänd, utforskad, säker, rasad, översvämmad eller farlig.
- Du skickar expeditioner som utforskar sträckor och hittar resurser.
- Du tar sträckor bit för bit och bygger utposter: vaktposter, förråd och barrikader. Utposter kräver invånare och förnödenheter.
- Grannstationer har egna ledare, befolkning och behov. Du kan handla med dem, ingå förbund, ta in flyktingar eller ta över dem.
- Varje station du kontrollerar blir en egen stationsvy som du kan gå ner i.
- Stationer du inte tittar på simuleras förenklat: befolkning, mat, el och moral som siffror.

**Strid**
- Strid sker i stationsvyn. När en grannstation, en flock eller de förvildade anfaller går du ner i den stationen eller utposten och försvarar den.
- Nätkartan visar var hotet kommer ifrån. Själva striden spelas i 3D.

**Barrikader och portar**
Moskvas tunnelbana byggdes med hermetiska portar. Stockholms gjorde det inte, så vitt vi har kunnat se. De överlevande har byggt sitt skydd själva:
- **Barrikader** av vagnar, sliprar och räler. Snabba att bygga, svaga.
- **Svetsade portar** av stålplåt från tågvagnar. Kräver svetsutrustning och gas.
- **Gjutna murar** med en lucka. Starka men långsamma att bygga, och de stänger tunneln för handel.
- **Larm** av burkar och tråd som varnar innan något når porten.

En sträckas tillstånd på nätkartan beror på vad du har byggt där.

**Murar i lager**
Varje mur dämpar en del av ljudet och ljuset. Fler lager ger mer skydd men kostar mer.

| Lager | Exempel | Dämpar | Kostar |
|---|---|---|---|
| Ytterst | Barrikad av sliprar och vagnar, larm av burkar | Lite, men varnar | Billigt, snabbt |
| Mitten | Svetsad port av stålplåt | Mycket ljus, en del ljud | Stål, gas, en svetsare |
| Innerst | Slussmur | Nästan allt ljus, mycket ljud, rök | Betong, stål, gummi, isolering, många arbetsdagar |

**Slussmuren** är stationens sista uppgradering: två portar med ett utrymme emellan.
- Den dämpar generatorn och pratet kraftigt, släpper inte ut ljus och håller rök och förorenad luft ute.
- Den är aldrig helt tät. Generatorn hörs svagt, och varje gång portarna öppnas släpps ljud och ljus ut.
- Ni hör också mindre av det som närmar sig. En tät station behöver vakter, en lyssningspost eller larm utanför.
- En tät station behöver fläktar med filter, alltså el. Utan el blir luften dålig bakom muren.

**Material**
- Betong går inte att tillverka. Den hämtas från byggarbetsplatser, till exempel bygget av nya blå linjen.
- Isolering kommer från madrasser, mineralull ur husväggar på ytan och gummi från tåg.
- Stål kommer från tågvagnar och räls.
- Invånare som bygger mur odlar inte och vaktar inte. En tät station kräver expeditioner efter material.

**Naturliga skydd och svagheter**
- **Ändstationer**, som Kungsträdgården, har bara en ingång från tunnelnätet och är lättast att försvara.
- **Blå linjen** går helt under jord i berg och är bäst skyddad.
- **Sträckor i dagen** är de farligaste: bron mellan T-Centralen, Gamla stan och Slussen, Tranebergsbron mellan Kristineberg och Alvik, Skansbron mellan Skanstull och Gullmarsplan, och Ropsten. Där är du ute på ytan.
- **Nödutgångar och schakt** leder upp till ytan. De är vägar för flykt men också för faror.
- **Uppgångar och rulltrappor** är stationernas svaga punkter mot ytan.
- **Kymlinge**, stationen på blå linjen som aldrig öppnades, är en naturlig plats för något som gömmer sig.

**Kontroll över sträckor**
Kontroll bygger på att du är där och kan försörja platsen. Varje krav är en regel i simuleringen.

| Steg | Krav | På kartan |
|---|---|---|
| Okänd | Ingen har varit där | Syns inte |
| Utforskad | Någon har gått hela sträckan | Grå linje |
| Hävdad | En post i andra änden, eller din station där | Tunn linje i din färg |
| Säkrad | Inget bo eller hot kvar, och båda ändarna hålls | Tjock linje i din färg |
| Försörjd | Sträckan hänger ihop med din station genom dina andra sträckor | Tjock linje som lyser |

- En post är en barrikad med en vakt, en lykta och stationens symbol målad på tunnelväggen. Symbolen syns i 3D.
- En sträcka kostar att hålla: vakter, bränsle till ljus och patruller.
- Om försörjningen bryts, posten överges eller ett bo flyttar in, faller sträckan tillbaka ett steg i taget. Det hindrar spelaren från att måla hela kartan.
- När du klickar på en sträcka visar spelet vad som är uppfyllt och vad som saknas, till exempel "Post i andra änden: behöver 1 vakt, 1 lykta, sliprar".

**Kontroll över tomma stationer**

| Steg | Krav |
|---|---|
| Utpost | Stationen är tom och rensad, och en hävdad sträcka leder dit |
| Bosättning | 3 till 5 invånare flyttar dit, en av dem ledare. Ljus, vatten och mat för en vecka |
| Station | Fler än 15 invånare, egen generator och egen odling. Får egen stationsvy och egna val av chef |

**Stationer där det bor folk**

| Sätt | Hur | Följd |
|---|---|---|
| Förbund | Handel och förtroende över tid | Får förbundets färg, inte din. Lojal men egen |
| Anslutning | Du försörjer dem när de har det svårt, och de röstar för att gå med | Hög lojalitet |
| Inflytande | Du får in folk och stöd tills din kandidat blir chef | Medel lojalitet, risk om det avslöjas |
| Våld | Strid i stationsvyn | Låg moral, fiender och risk för uppror länge |

**Färger på kartan**
- Din färg för det du kontrollerar.
- Andras färger bara där du har varit eller fått veta genom handel.
- Kartan visar det du senast visste. En annan stations färg kan ha ändrats sedan dess.
- Omstridda sträckor visas randiga.

**Första expansionen**
Kungsträdgården ligger på blå linjen, som leder till T-Centralen. Navet där alla linjer möts blir första stora målet. Vägen dit går genom halvfärdiga och rasade tunnlar.

**Ordning**
Nätkartan byggs efter milstolparna i README. Stationsvyn måste fungera först. Simuleringen byggs ändå för flera stationer från början, se Teknik.

## Tunnlarna

**Från stationen till tunneln**
- Ingen mellansekvens. Du ser expeditionen gå genom porten och in i mörkret. De första hundra metrarna tunnel hör till stationens scen.
- Längre bort är varje sträcka på nätkartan en egen scen. Godot laddar den i bakgrunden medan expeditionen går, så att övergången blir en kort tonning, inte en laddningsskärm.

**Sträckor av moduler**
- Stationerna byggs för hand, eftersom de är verkliga platser.
- Tunnlarna sätts ihop av moduler: rak bit, kurva, ras, sidorum, servicedörr, nödutgång.
- Varje sträcka byggs med samma frö varje gång, så den ser likadan ut vid nästa besök. Ett ras du har röjt förblir röjt.

**En levande värld**
- Hela nätet simuleras hela tiden: handelskaravaner, flockar, flyktingar och rövare rör sig på sträckorna med egna mål.
- De är bara data: vilken sträcka, hur långt in och vart de är på väg. Hundratals sådana agenter kostar nästan ingenting.
- Möten uppstår av sig själva. När en agent och din expedition är på samma sträcka och den är laddad, får agenten en kropp i 3D. Inga möten slumpas fram ur tomma intet.
- En flock som går mot din station kommer verkligen fram, även om du inte tittar.
- Tätheten styrs av sträckans tillstånd. Säkra sträckor har få möten, farliga många. Barrikader och vakter minskar dem.

## Ljus, mörker och synfält

- Allt i den laddade sträckan finns och ritas i 3D. Det som inte är upplyst syns inte, eftersom inget ljus träffar det.
- Tunnlarna har inget grundljus. Mörkret ska vara svart, inte grått.
- Andras ljus syns på långt håll. En handlares lykta syns innan handlaren gör det. En flock syns som silhuetter mot en upplyst plats.
- Ljuskällor räcker olika långt: ficklampan långt i en smal kon, facklan kort runt om, lyktan medelavstånd åt alla håll.
- Ett karaktärsdrag kan ge bättre mörkerseende.
- Ljuset lockar. Ju starkare du lyser, desto längre syns du.
- Simuleringen räknar ljusnivå och synlinjer på sitt eget rutnät, så att AI:n vet vem som ser vem. Godot ritar samma ljus, men räknar inte åt simuleringen.
- Sträckor du har besökt men inte är på just nu visas grå på nätkartan, som de såg ut senast.

**Stationens kunskap**
- Stationen minns det invånarna har sett: varje plats är okänd, eller sågs senast en viss dag och såg ut på ett visst sätt.
- Minnet kan vara fel. Ett ras eller en flock som har kommit sedan dess syns inte förrän någon går dit igen.
- En expedition för hem det den har sett. Dör expeditionen innan dess förlorar stationen kunskapen, tills någon hittar kroppen och dagboken.

## Ljud

Tunnlar leder ljud långt. Ljudet följer tunneln runt hörn men går inte genom berg.

| Ljud | Hörs ungefär |
|---|---|
| Steg när man smyger | 5 m |
| Vanliga steg | 15 m |
| Prat | 25 m |
| Springa, bära tungt | 40 m |
| Generatorn | 60 m, hela tiden |
| Metall som slår, en dörr som smäller | 100 m |
| Skott | Hela sträckan och in i grannsträckorna |

- Varje ljud är en händelse i simuleringen med plats, styrka och typ. Det sprids längs rutnätet där det går att gå. Dörrar och murar dämpar.
- Starka ljud fortsätter in i grannsträckorna med lägre styrka, även om de inte är laddade.
- Varje varelse har en hörsel. Muterade djur ser dåligt men hör bra.
- Ljud som du inte ser källan till visas som en riktning vid kanten av ljuset.
- I Godot spelas ljudet med `AudioStreamPlayer3D` och eko i tunnlarna. Simuleringen avgör vem som hör.

**Val som följer av ljud och ljus**
- Generatorn ger ljus och mat men brummet lockar djur. Att stänga av den ett tag blir ett taktiskt val.
- Ficklampan syns långt men är tyst. Facklan syns kort men knastrar.
- Ett skott löser problemet framför dig men kan locka ett större från grannsträckan.

## Mål

Spelet är oändligt. Fyra spår ger riktning:

1. **Överleva:** Klara bränslekrisen i introduktionen, sedan vinter, sjukdomar och översvämningar.
2. **Bygga upp:** Stationen växer i nivåer. Exempel: fungerande el, renat vatten, filtrerad luft, ett öppnat stängt schakt och en säker utgång till parken ovanför.
3. **Växa utåt:** Ta tunnelsträckor, bygg utposter och vinn grannstationer på nätkartan. Första målet är T-Centralen.
4. **Upptäcka:** En berättelse om omvärlden. Exempel: en trasig radio, signaler från andra stationer, och rykten om att någon lever kvar vid Muskö.

Ett långsiktigt mål som passar oändlig speltid: att stationen överlever en generation, så att barnen som föddes på stationen blir dess vuxna.

## Ton

- Svält och barn som dör finns. Barns död visas utanför bild, och spelaren kan aldrig skada barn direkt.
- Avrättning finns som straff i lagarna, med stor kostnad i moral.
- Kannibalism, självmord och tortyr finns inte i spelet.

## Gränssnitt

- Läget visas mest i världen: gångstil, ikoner över huvuden när något är fel, och ljuset på stationen.
- Paneler med behov, arbete och lager öppnas när du klickar på en invånare, en byggnad eller lagret.
- Larm visas kort i kanten av skärmen när något kräver beslut: en flock närmar sig, maten räcker två dagar, ett val ska hållas.
- Rapporter från andra stationer kommer som brev från budbärare.

## Grafik

- Low poly 3D med runda figurer, platt skuggning och få eller inga texturer.
- Figurer byggs av lager: kropp, huvud, hår och kläder, för många varianter.
- Animationer: ett skelett för alla, cirka tio grundanimationer, gångstil som blandas fram efter tillstånd.
- Ljuset är en del av spelet: lysrör, facklor, lägereld och ficklampa med skuggor.

## Teknik

- Godot 4 med C# och .NET 8.
- Blender för modeller, exporterade som `.glb`.
- Simuleringen är vanlig C# utan Godot-noder. Godot-noderna visar bara simuleringen. Det gör logiken testbar och multiplayer möjligt senare.
- Simuleringen klarar flera stationer från början. Invånare, lager, el och moral hör till en `Station`, inte till spelet som helhet. En `World` håller alla stationer och tunnelsträckor. Under milstolparna finns bara en station i världen.
- `World` är ett nät: `Station` är noder och `TunnelSegment` är kanter med längd, tillstånd, ägare och kontrollsteg.
- Positioner i simuleringen är abstrakta: en station, eller en sträcka plus ett avstånd i meter. 3D-koordinater finns bara i vyn.
- Varje station och sträcka har ett rutnät i simuleringen, en ruta per meter, som säger var det går att gå och vad som skymmer sikt och ljud. Vägsökning, synlinjer, ljus och ljud räknas på rutnätet i vanlig C#.
- `Knowledge` hör till en station och minns vad som sågs var och när.
- En `Expedition` är en grupp invånare med packning som rör sig på nätet.
- En klocka driver allt: stationer, expeditioner och agenter på nätet.
- Innehåll är data, inte kod. Föremål, byggnader, verkstäder, karaktärsdrag och lagar definieras i datafiler, till exempel Godot-resurser eller JSON. En ny vara läggs till utan att koden ändras.
- Utility AI är ett generellt system med handlingar som räknar fram poäng. Samma system används för invånare, röstning och föreståndare.
- `Station` har plats för en ledare och en lista med lagar från början, även om de används först senare.

## Språk

- Spelets texter skrivs på engelska.
- Platsnamn är svenska: T-Centralen, Slussen, Kungsträdgården.
- Svenska ord som skyddsrum, fika och pant används där sammanhanget förklarar dem.
- Typsnittet måste ha å, ä och ö.

## Öppna frågor

- **Namn:** Bunkerbyn är arbetsnamn. Ett engelskt namn kan behövas för Steam.
- **Ljud och musik.**
- **Plattformar och pris.**
- **Multiplayer:** Flera stationer, kanske samma station. Väntar tills enspelarläget fungerar.
- **Grannstationer:** Vilka stationer finns runt Kungsträdgården, och vem leder dem?
- **Portar i verkligheten:** Har Stockholms tunnelbana tryckdörrar eller skyddsportar? Fråga SL eller Trafikförvaltningen. Om svaret är ja kan de bli en del av lore.
