# Kom igång

Instruktionerna gäller Ubuntu Linux. Projektet saknar kod än så länge, så stegen under Skapa projektet görs en gång när arbetet börjar.

## 1. .NET 8 SDK

```bash
sudo apt update
sudo apt install -y dotnet-sdk-8.0
dotnet --version
```

Versionen ska börja med `8.`.

## 2. Godot 4 med .NET

1. Ladda ner **Godot Engine - .NET** för Linux från https://godotengine.org/download/linux/. Välj den senaste stabila 4.x-versionen. Den vanliga versionen utan .NET saknar stöd för C#.
2. Packa upp zip-filen, till exempel till `~/Program/Godot`.
3. Starta den körbara filen i mappen.

## 3. Blender

```bash
sudo snap install blender --classic
```

Exportera modeller som glTF binary (`.glb`) till mappen `models/`. Godot importerar dem direkt.

## 4. Skapa projektet

Görs en gång:

1. Starta Godot och skapa ett nytt projekt i rotmappen för repot, med renderaren Forward+.
2. Skapa ett första C#-skript i Godot. Då skapar Godot `Bunkerbyn.csproj` och `Bunkerbyn.sln`.
3. Committa `project.godot`, `.csproj`, `.sln` och alla `.import`-filer. Mappen `.godot/` ignoreras.

## 5. Kör spelet

Tryck F5 i Godot, eller bygg C#-koden från terminalen:

```bash
dotnet build
```

## Gratis modeller

- Kenney: https://kenney.nl/assets, CC0.
- Quaternius: https://quaternius.com, CC0, med animerade figurer.
- Mixamo: gratis animationer från Adobe som får användas i spel. Läs villkoren innan du lägger till dem.

Varje fil läggs till i ASSETS.md med källa och licens.

## Formatering

Reglerna står i `.editorconfig`. Kontrollera formateringen innan du pushar:

```bash
dotnet format --verify-no-changes
```

Utan flaggan rättar kommandot filerna. I VS Code formaterar tillägget C# Dev Kit vid sparning enligt samma regler.

## CI

`.github/workflows/build.yml` kör `dotnet build` och `dotnet format --verify-no-changes` på varje pull request mot main. Godot-projektet byggs med paketet `Godot.NET.Sdk` från NuGet, så CI behöver inte Godot installerat. Stegen hoppas över tills det finns en `.csproj`.
