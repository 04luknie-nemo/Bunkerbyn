# Bunkerbyn (arbetsnamn)

En kolonisimulator med överlevnad i Stockholms tunnelbana, sju år efter ett kärnvapenkrig. Du styr stationen Kungsträdgården och dess invånare. På stationen ger du order. I tunnlarna och på ytan styr du en utvald invånare direkt.

Byggs i Godot 4 med C# och low poly 3D.

## Koncept

Inspiration: This War of Mine, RimWorld, Frostpunk, Stardew Valley och Metro-modden till Hearts of Iron IV.

**På stationen**
- Odla svamp och rotfrukter under lysrör.
- Håll igång generatorn, vattnet och luften.
- Invånare med behov, färdigheter, personlighet och roller.
- En chef, moral, val och risk för uppror.

**I tunnlarna och på ytan**
- Ficklampa i mörkret.
- Gasmask med begränsat antal filter.
- Leta bränsle, delar och frön.
- Muterade djur och desperata människor.

**Nätkartan**
- Stockholms tunnelbana som strategikarta.
- Ta tunnelsträckor, bygg utposter och vinn grannstationer.
- Första målet är T-Centralen.

**Döden**
- Permanent. Du väljer en ny invånare ur stationens pool.
- Kroppen och dagboken ligger kvar och går att hämta.

Alla beslut finns i [docs/DESIGN.md](docs/DESIGN.md).

## Tekniska beslut

| Område | Val |
|---|---|
| Motor | Godot 4 (.NET) |
| Språk | C#, .NET 10 |
| Utvecklingsmiljö | Ubuntu Linux |
| Kamera | 3/4-vy uppifrån, roterar, lutar och zoomar fritt |
| Grafik | Low poly 3D med runda figurer och platt skuggning |
| Modeller | Blender, exporterade som `.glb` |
| Indata | Tangentbord och mus, handkontroll |
| Spelets språk | Engelska, med svenska platsnamn |

## Mappstruktur

```
Bunkerbyn/
  project.godot
  Bunkerbyn.csproj
  scenes/         Station.tscn, TunnelSegment.tscn, Resident.tscn, tunnelmoduler
  scripts/
    Simulation/   World, Station, TunnelSegment, Grid, Knowledge, Resident, Needs, Actions, Clock (vanlig C#, inga noder)
    View/         ResidentView, CameraRig, StationView (Godot-noder)
  models/         .glb från Blender
  docs/
```

Simuleringen vet inget om grafiken. Noderna i `View/` läser simuleringen och visar den.

## Milstolpar

1. [ ] Kamera som roterar, lutar och zoomar över en tom perrong.
2. [ ] Perrongen byggd av enkla former, som i prototypen.
3. [ ] En invånare som går dit du klickar.
4. [ ] Klocka, dagar och spelhastighet: paus, 1x, 2x, 3x.
5. [ ] Behov: hunger och sömn. Invånaren går själv till mat och säng.
6. [ ] Svampodling: plantera, vattna, skörda efter tre dagar.
7. [ ] Lager med tak.
8. [ ] Generator och bränsle: el av och på, facklor som reserv.
9. [ ] Introduktionen: vakna skadad, Nadia och bränslekrisen.
10. [ ] Tunneln: styr en invånare direkt med ficklampa och filter.

## Börja i liten skala

En station, en tunnel och en ytkarta. Nätkartan med grannstationer byggs när milstolparna är klara. Simuleringen förbereds ändå för flera stationer från början.

## Upphovsrätt

- Inget "Metro" i namnet.
- Inga namn, figurer eller monsterdesigner från Metro-serien.
- Bara egna assets eller assets med tydlig licens, till exempel CC0 från Kenney eller Quaternius.
- Varje assets källa listas i [ASSETS.md](ASSETS.md).

## Kom igång

Se [setup/README.md](setup/README.md) för installation av .NET 10, Godot 4 och Blender på Ubuntu.

## Arbetssätt med AI

Reglerna för AI-assistenter står i [AGENTS.md](AGENTS.md). [docs/AI-ARBETSSATT.md](docs/AI-ARBETSSATT.md) beskriver nivåerna av hjälp, etapperna och AI-loggen.

## Filer i roten

| Fil | Innehåll |
|---|---|
| `AGENTS.md` | Regler för alla AI-verktyg |
| `CLAUDE.md` | Pekar på AGENTS.md |
| `ASSETS.md` | Källa och licens för varje asset |
| `docs/DESIGN.md` | Alla designbeslut och öppna frågor |
| `docs/AI-ARBETSSATT.md` | Arbetssätt och AI-logg |
| `docs/BESLUT.md` | Designbeslut med alternativ och avvägningar |
| `docs/FELSOKNING.md` | Felsökningslogg från symptom till rotorsak |
| `setup/README.md` | Installation och körning |
| `.editorconfig` | Formateringsregler för C# |
| `.github/workflows/build.yml` | Bygge och formatkontroll på varje pull request |
