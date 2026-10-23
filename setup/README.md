# Kom igång

Instruktionerna gäller Ubuntu Linux. Projektet saknar kod än så länge, så stegen under Kör spelet gäller när det första MonoGame-projektet finns.

## 1. .NET 8 SDK

```bash
sudo apt update
sudo apt install -y dotnet-sdk-8.0
dotnet --version
```

Versionen ska börja med `8.`.

## 2. MonoGame-mallar och MGCB-editorn

```bash
dotnet new install MonoGame.Templates.CSharp
dotnet tool install --global dotnet-mgcb-editor
mgcb-editor --register
```

MGCB-editorn bygger sprites, ljud och typsnitt i `Content/`.

## 3. Skapa projektet

Körs en gång, från rotmappen:

```bash
dotnet new mgdesktopgl -n Bunkerbyn -o .
```

## 4. Kör spelet

```bash
dotnet restore
dotnet tool restore
dotnet run
```

## Grafik

- Aseprite eller LibreSprite.
- 16x16 pixlar per ruta.
- Spara som PNG i `Content/` och lägg till filen i ASSETS.md.

## Formatering

Reglerna står i `.editorconfig`. Kontrollera formateringen innan du pushar:

```bash
dotnet format --verify-no-changes
```

Utan flaggan rättar kommandot filerna. I VS Code formaterar tillägget C# Dev Kit vid sparning enligt samma regler.

## CI

`.github/workflows/build.yml` kör `dotnet build` och `dotnet format --verify-no-changes` på varje pull request mot main. Stegen hoppas över tills det finns en `.csproj`.
