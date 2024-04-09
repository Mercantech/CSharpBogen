## Arrays

I C# bruges arrays til at gemme og håndtere en samling af elementer af samme type. En array er en datastruktur, der giver mulighed for at gemme flere værdier i en enkelt variabel.

For at oprette en array i C#, skal du angive typen af elementer, der skal gemmes i arrayet, og derefter angive størrelsen på arrayet. For eksempel kan du oprette en array af heltal med ti elementer ved at skrive:

```csharp
int[] numbers = new int[10];

```

Her har vi oprettet en array ved navn `numbers`, der kan gemme ti heltal. Arrayet initialiseres med standardværdierne for den givne type, i dette tilfælde er det 0 for heltal.

Du kan tilgå og manipulere elementerne i arrayet ved hjælp af indekser. Indekserne starter altid fra 0, så det første element i arrayet har indeks 0, det andet element har indeks 1 osv. For at tilgå et element i arrayet kan du bruge følgende syntaks:

```csharp
int firstNumber = numbers[0];

```

Her har vi tilgået det første element i arrayet `numbers` og gemt det i variablen `firstNumber`.

Du kan også ændre værdien af et element i arrayet ved at tildele en ny værdi til det pågældende indeks:

```csharp
numbers[0] = 42;

```

Her har vi ændret værdien af det første element i arrayet `numbers` til 42.

Arrays er vigtige i C# og andre programmeringssprog, da de giver mulighed for at gemme og arbejde med en samling af data på en struktureret måde. De gør det nemt at håndtere flere elementer af samme type og giver mulighed for effektiv adgang og manipulation af data. Arrays bruges ofte til opbevaring af lister af elementer, såsom tal, strenge eller objekter.

Det er vigtigt at være opmærksom på arrayets størrelse og ikke forsøge at tilgå eller ændre elementer uden for det gyldige indeksområde, da det kan føre til uforudsigelig adfærd eller fejl i programmet.

## Lister

Lister i C# er en datastruktur, der bruges til at gemme og håndtere en samling af elementer af samme type. De er vigtige, fordi de giver fleksibilitet og dynamisk størrelse i forhold til arrays.

For at bruge lister i C#, skal du først importere `System.Collections.Generic`-namespace. Derefter kan du oprette en liste ved at angive typen af elementer, der skal gemmes i listen. For eksempel kan du oprette en liste af heltal ved at skrive:

```csharp
using System.Collections.Generic;

List<int> numbers = new List<int>();

```

Her har vi oprettet en tom liste ved navn `numbers`, der kan gemme heltal.

Du kan tilføje elementer til listen ved hjælp af `Add()`-metoden. For eksempel:

```csharp
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

```

Her har vi tilføjet tre heltal til `numbers`-listen.

Du kan også tilgå og manipulere elementer i listen ved hjælp af indekser. Indekserne starter fra 0, så det første element i listen har indeks 0, det andet element har indeks 1 og så videre. For at tilgå et element i listen kan du bruge følgende syntaks:

```csharp
int firstNumber = numbers[0];

```

Her har vi tilgået det første element i `numbers`-listen og gemt det i variablen `firstNumber`.

Du kan ændre værdien af et element i listen ved at tildele en ny værdi til det pågældende indeks:

```csharp
numbers[0] = 42;

```

Her har vi ændret værdien af det første element i `numbers`-listen til 42.

Lister kan også have dynamisk størrelse, hvilket betyder, at du kan tilføje eller fjerne elementer efter behov. Du kan bruge metoder som `Add()`, `Insert()`, `Remove()` og `Clear()` til at tilføje, indsætte, fjerne og rydde elementer i listen.

Lister er nyttige, når du har brug for at arbejde med samlinger af data, der kan ændre sig i størrelse. De giver dig mulighed for at tilføje, fjerne og manipulere elementer på en fleksibel måde. Lister er også mere effektive end arrays, når det kommer til håndtering af store datamængder og dynamisk allokering af hukommelse.

Det er vigtigt at huske, at lister er reference-typer i C#, hvilket betyder, at du arbejder med en henvisning til listen og ikke selve listen. Derfor skal du være opmærksom på, hvordan du kopierer og deler lister mellem forskellige variabler og metoder.

Når du bruger lister, kan du udnytte de mange indbyggede metoder og egenskaber, der gør det nemt at manipulere og behandle data. Listens fleksibilitet og funktionalitet gør den til en vigtig datastruktur i C#-programmering.

Både lister og arrays i C# er datastrukturer, der bruges til at gemme og håndtere en samling af elementer af samme type. Men der er nogle vigtige forskelle mellem dem:

**Arrays:**

- Arrays er en fast størrelse datastruktur, hvor størrelsen på arrayet er defineret ved oprettelsen og kan ikke ændres senere.
- Elementerne i et array er gemt i en kontinuerlig blok i hukommelsen, hvilket giver en hurtig og direkte adgang til elementerne via indeksering.
- Du kan tilgå og ændre elementerne i et array ved hjælp af indekser.
- Arrays bruger mindre hukommelse end lister, da de ikke har nogen ekstra baggrundsinformation eller metoder.
- Hvis du vil ændre størrelsen på et array, skal du oprette et nyt array med den ønskede størrelse og kopiere elementerne fra det gamle array til det nye.

**Lister:**

- Lister er en dynamisk størrelse datastruktur, hvor størrelsen kan ændres efter behov.
- Elementerne i en liste er gemt i en dynamisk allokering af hukommelse, hvilket giver mulighed for nem tilføjelse og fjernelse af elementer.
- Du kan tilføje, indsætte, fjerne og manipulere elementer i en liste ved hjælp af forskellige indbyggede metoder og egenskaber.
- Lister bruger mere hukommelse end arrays, da de har ekstra baggrundsinformation og metoder.
- Lister giver dig mulighed for at arbejde med samlinger af data, der kan ændre sig i størrelse efter behov, og tilbyder mere fleksibilitet og funktionalitet end arrays.

Generelt set, hvis du ved, at størrelsen på dine data er fast, og du har brug for en hurtig og direkte adgang til elementerne baseret på indeksering, er et array en god mulighed. Hvis du derimod har brug for en dynamisk størrelse og fleksibilitet til at tilføje, fjerne og manipulere elementer, er en liste mere passende.

Begge datastrukturer har deres anvendelsesområder og fordele afhængigt af situationen og kravene i din kode.

Personligt vælger jeg næsten altid en liste, fordi de er mere fleksible end et array!
