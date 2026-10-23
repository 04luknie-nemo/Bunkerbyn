# Bunkerbyn (arbetsnamn)

Ett 2D-spel i C# med MonoGame. Du bor i en tunnelbanestation efter apokalypsen. På dagen bygger du upp stationen. På natten går du ut i tunnlarna och upp på ytan.

## Koncept

Inspiration: Metro, Stardew Valley och Haunted Chocolatier.

**Dag på stationen**
- Odla svamp och rotfrukter under lysrör.
- Föd upp djur.
- Laga mat.
- Reparera generatorn.
- Lär känna invånarna.

**Natt i tunnlar och på ytan**
- Ficklampa i mörkret.
- Gasmask med ett begränsat antal filter.
- Leta delar och frön.
- Mutanter i mörkret.

**Övrigt**
- Ammunition fungerar som valuta.
- Grannstationer med egna fraktioner (senare).
- Stationen förändras synligt när du bygger upp den.
- Egen värld och lore, gärna i en svensk eller nordisk stad.

## Tekniska beslut

| Område | Val |
|---|---|
| Motor | MonoGame (DesktopGL) |
| Språk | C#, .NET 8 |
| Utvecklingsmiljö | Ubuntu Linux |
| Kamera | Uppifrån med 3/4-vy, som Stardew Valley |
| Grafik | Pixelart, 16x16 pixlar per ruta, uppskalad med `SamplerState.PointClamp` |
| Grafikverktyg | Aseprite eller LibreSprite |

## Mappstruktur

```
Bunkerbyn/
  Game1.cs
  Core/        Input, Camera, TimeManager
  World/       TileMap, Tile, Crop
  Entities/    Player
  Scenes/      StationScene, TunnelScene
  Content/     sprites, ljud, typsnitt
```

## Milstolpar

1. [ ] En gubbe som går på ett rutnät med tangentbordet.
2. [ ] Tilemap för perrongen, ritad från en bild.
3. [ ] Klocka och dagar som går.
4. [ ] Plantera svamp, vattna och skörda efter tre dagar.
5. [ ] Inventarie med några platser.
6. [ ] Dörr till en mörk tunnel med ficklampa och filter som räknar ner.

## Börja i liten skala

En station, en tunnel och en ytkarta. Inga fraktionskrig, ingen öppen värld och ingen avancerad AI i början.

## Upphovsrätt

- Inget "Metro" i namnet.
- Inga namn, figurer eller monsterdesigner från Metro-serien.
- Bara egna assets eller assets med tydlig licens, till exempel CC0 från Kenney eller OpenGameArt.
- Varje assets källa listas i `ASSETS.md`.

## Kom igång

Kräver .NET 8 SDK.

```bash
dotnet tool install --global dotnet-mgcb-editor
dotnet run
```

Projektet saknar kod än så länge. Instruktionerna gäller när det första MonoGame-projektet finns på plats.
