# 2-Variables

Microsoft dokumentation kan findes her - [Variabler](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/variables)

Variabler i C# er brugt til at gemme og manipulere data. En variabel kan være en bestemt type, f.eks. et heltal, en streng eller en boolean værdi.

For at erklære en variabel i C#, skal du angive dens type og give den et navn. For eksempel kan du erklære en variabel af typen `int` (heltal) ved at skrive:

```csharp
int nummer;

```

Her har vi erklæret en variabel ved navn `nummer` af typen `int`. Du kan også initialisere variablen med en startværdi ved at tildele den en værdi. For eksempel:

```csharp
int alder = 25;

```

Her har vi erklæret og initialiseret en variabel ved navn `alder` af typen `int` med værdien 25.

Når variablen erklæres, kan du til enhver tid tildele en ny værdi til den. For eksempel:

```csharp
alder = 30;

```

Du kan også kombinere variabler og udføre operationer med dem. For eksempel:

```csharp
int x = 5;
int y = 10;
int sum = x + y;

```

Her har vi erklæret tre variabler, `x`, `y` og `sum`, og udført en addition mellem `x` og `y` og gemt resultatet i `sum`.

Variabler kan også have forskellige scopes, hvilket betyder, at de kun er synlige og tilgængelige inden for visse områder af din kode. For eksempel kan du erklære en variabel inden for en metode, og den vil kun være synlig inden for den metode.

Det er vigtigt at forstå, hvordan man arbejder med variabler i C#, da de er fundamentale for at gemme og manipulere data i programmeringssprog.

Her er en liste over de enkelte primitive typer af variabler i C#:

- `int`: Bruges til at gemme heltal.
- `float`: Bruges til at gemme decimaltal med lav præcision.
- `double`: Bruges til at gemme decimaltal med høj præcision.
- `bool`: Bruges til at gemme en sand (`true`) eller falsk (`false`) værdi.
- `char`: Bruges til at gemme en enkelt karakter.
- `string`: Bruges til at gemme en sekvens af karakterer.
