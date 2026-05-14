# LINQ i C#

LINQ står for **Language Integrated Query** og gør det muligt at søge, filtrere, sortere, gruppere og transformere data direkte i C#.

Du kan bruge LINQ på blandt andet:

- arrays
- `List<T>`
- `Dictionary<TKey, TValue>`
- tekst og tegn
- filer, når de er læst ind som linjer
- databaser, fx via Entity Framework

LINQ er især vigtigt, fordi mange programmer handler om at tage en samling data og stille spørgsmål til den:

- Hvilke elever har afleveret?
- Hvad er den dyreste vare?
- Hvor mange ordrer ligger over 500 kr.?
- Hvilke produkter findes i hver kategori?
- Hvad skal vises på skærmen efter filtrering og sortering?

## Før LINQ: klassisk loop

Forestil dig, at vi har en liste med tal og vil finde alle lige tal.

```csharp
List<int> tal = new() { 1, 2, 3, 4, 5, 6 };

List<int> ligeTal = new();

foreach (int t in tal)
{
    if (t % 2 == 0)
    {
        ligeTal.Add(t);
    }
}

foreach (int t in ligeTal)
{
    Console.WriteLine(t);
}
```

Det virker fint, men vi skal selv:

- oprette en ny liste
- skrive loopet
- skrive `if`
- tilføje elementer manuelt

## Med LINQ: samme idé kortere

```csharp
using System.Linq;

List<int> tal = new() { 1, 2, 3, 4, 5, 6 };

var ligeTal = tal.Where(t => t % 2 == 0);

foreach (int t in ligeTal)
{
    Console.WriteLine(t);
}
```

`Where` betyder: behold kun de elementer, hvor betingelsen er sand.

## Hvorfor LINQ?

LINQ giver:

- mindre boilerplate-kode
- bedre læsbarhed, når man er vant til syntaksen
- stærk typesikkerhed
- samme tankegang på tværs af arrays, lister og databaser
- nemmere kode, når man skal kombinere filtrering, sortering og udvælgelse

LINQ erstatter ikke loops. Loops er stadig vigtige. LINQ er bare ofte bedre, når målet er at **spørge ind til data**.

## Husk `using System.Linq;`

I mange moderne C#-projekter er `System.Linq` allerede importeret globalt, men hvis metoder som `Where`, `Select` og `OrderBy` ikke findes, så mangler du typisk:

```csharp
using System.Linq;
```

## Lambda-udtryk

LINQ bruger ofte lambda-udtryk.

```csharp
t => t % 2 == 0
```

Det kan læses som:

> Tag et element `t`, og returnér om `t % 2 == 0`.

Et lambda-udtryk har typisk denne form:

```csharp
parameter => resultat
```

Eksempler:

```csharp
tal.Where(t => t > 10);
navne.Where(n => n.StartsWith("A"));
produkter.Select(p => p.Navn);
personer.OrderBy(p => p.Alder);
```

## Method syntax

Den mest brugte LINQ-stil i moderne C# er **method syntax**.

```csharp
var resultat = tal
    .Where(t => t > 3)
    .OrderBy(t => t)
    .Select(t => t * 2);
```

Man læser kæden oppefra og ned:

1. Start med `tal`
2. Behold kun tal større end 3
3. Sortér dem
4. Gang hvert tal med 2

## Query syntax

LINQ kan også skrives i en SQL-lignende stil.

```csharp
var resultat =
    from t in tal
    where t > 3
    orderby t
    select t * 2;
```

Begge versioner kan give samme resultat. I almindelig C#-kode vil du ofte se method syntax mest.

## Eksempeldata til resten af kapitlet

Mange LINQ-eksempler bliver nemmere at forstå med objekter.

```csharp
public class Produkt
{
    public string Navn { get; set; } = "";
    public string Kategori { get; set; } = "";
    public decimal Pris { get; set; }
    public int Lager { get; set; }
}
```

```csharp
List<Produkt> produkter = new()
{
    new Produkt { Navn = "Tastatur", Kategori = "IT", Pris = 399, Lager = 8 },
    new Produkt { Navn = "Mus", Kategori = "IT", Pris = 149, Lager = 20 },
    new Produkt { Navn = "Skærm", Kategori = "IT", Pris = 1299, Lager = 4 },
    new Produkt { Navn = "Kaffe", Kategori = "Kantine", Pris = 45, Lager = 50 },
    new Produkt { Navn = "Notesbog", Kategori = "Kontor", Pris = 29, Lager = 100 },
    new Produkt { Navn = "Whiteboard", Kategori = "Kontor", Pris = 699, Lager = 2 }
};
```

## `Where` - filtrering

`Where` bruges til at vælge de elementer, der matcher en betingelse.

```csharp
var dyreProdukter = produkter.Where(p => p.Pris > 500);

foreach (Produkt produkt in dyreProdukter)
{
    Console.WriteLine($"{produkt.Navn}: {produkt.Pris} kr.");
}
```

Flere betingelser kan kombineres med `&&` og `||`.

```csharp
var dyreItProdukter = produkter
    .Where(p => p.Kategori == "IT" && p.Pris > 500);
```

## `Select` - vælg eller omform data

`Select` bruges til at lave hvert element om til noget andet.

```csharp
var produktNavne = produkter.Select(p => p.Navn);
```

Du kan også lave nye anonyme objekter:

```csharp
var visningsData = produkter.Select(p => new
{
    p.Navn,
    PrisTekst = $"{p.Pris} kr.",
    ErPåLager = p.Lager > 0
});
```

Det er smart, når du kun skal bruge noget af dataen.

## `OrderBy` og `ThenBy` - sortering

```csharp
var sorteretEfterPris = produkter.OrderBy(p => p.Pris);
```

Faldende sortering:

```csharp
var dyresteFørst = produkter.OrderByDescending(p => p.Pris);
```

Sortering på flere felter:

```csharp
var sorteret = produkter
    .OrderBy(p => p.Kategori)
    .ThenBy(p => p.Pris);
```

Her sorteres først på kategori og derefter på pris inden for hver kategori.

## `First`, `FirstOrDefault`, `Single` og `SingleOrDefault`

`First` henter det første element, der matcher.

```csharp
Produkt førsteItProdukt = produkter.First(p => p.Kategori == "IT");
```

Hvis der ikke findes et match, kaster `First` en fejl. Derfor er `FirstOrDefault` ofte sikrere.

```csharp
Produkt? fundet = produkter.FirstOrDefault(p => p.Navn == "Printer");

if (fundet is null)
{
    Console.WriteLine("Produktet blev ikke fundet.");
}
else
{
    Console.WriteLine(fundet.Navn);
}
```

`Single` betyder: der skal være præcis ét match.

```csharp
Produkt produkt = produkter.Single(p => p.Navn == "Mus");
```

Brug `Single`, når det er en fejl, hvis der findes nul eller flere resultater. Brug `First`, når du bare vil have det første.

## `Any` og `All`

`Any` tjekker, om mindst ét element matcher.

```csharp
bool findesDyreProdukter = produkter.Any(p => p.Pris > 1000);
```

`All` tjekker, om alle elementer matcher.

```csharp
bool alleErPåLager = produkter.All(p => p.Lager > 0);
```

`Any` er også en god måde at tjekke, om en liste indeholder noget:

```csharp
if (produkter.Any())
{
    Console.WriteLine("Der er produkter i listen.");
}
```

## `Count`, `Sum`, `Average`, `Min` og `Max`

LINQ kan lave simple beregninger.

```csharp
int antalProdukter = produkter.Count();
int antalItProdukter = produkter.Count(p => p.Kategori == "IT");

decimal samletVærdi = produkter.Sum(p => p.Pris * p.Lager);
decimal gennemsnitsPris = produkter.Average(p => p.Pris);
decimal billigstePris = produkter.Min(p => p.Pris);
decimal dyrestePris = produkter.Max(p => p.Pris);
```

Pas på `Average`, `Min` og `Max` på tomme lister. Det giver fejl.

```csharp
var tomListe = new List<int>();

if (tomListe.Any())
{
    Console.WriteLine(tomListe.Average());
}
```

## `GroupBy` - gruppering

`GroupBy` bruges til at samle data i grupper.

```csharp
var grupper = produkter.GroupBy(p => p.Kategori);

foreach (var gruppe in grupper)
{
    Console.WriteLine(gruppe.Key);

    foreach (Produkt produkt in gruppe)
    {
        Console.WriteLine($"- {produkt.Navn}");
    }
}
```

`gruppe.Key` er værdien, der grupperes på. Her er det kategorien.

Du kan også lave en opsummering pr. gruppe:

```csharp
var kategoriOversigt = produkter
    .GroupBy(p => p.Kategori)
    .Select(g => new
    {
        Kategori = g.Key,
        AntalProdukter = g.Count(),
        SamletLagerværdi = g.Sum(p => p.Pris * p.Lager)
    });
```

## `Distinct` - fjern dubletter

På simple typer er `Distinct` nemt.

```csharp
List<string> kategorier = produkter
    .Select(p => p.Kategori)
    .Distinct()
    .ToList();
```

På objekter kræver dubletlogik ofte, at man vælger et bestemt felt først, som i eksemplet ovenfor.

## `Contains`

`Contains` tjekker, om en samling indeholder en værdi.

```csharp
List<string> tilladteKategorier = new() { "IT", "Kontor" };

var udvalgteProdukter = produkter
    .Where(p => tilladteKategorier.Contains(p.Kategori));
```

Det er nyttigt, når brugeren vælger flere filtre.

## `Skip` og `Take`

`Skip` springer elementer over. `Take` tager et bestemt antal.

```csharp
var førsteSide = produkter
    .OrderBy(p => p.Navn)
    .Skip(0)
    .Take(3);

var andenSide = produkter
    .OrderBy(p => p.Navn)
    .Skip(3)
    .Take(3);
```

Det bruges ofte til paging, altså side 1, side 2, side 3 osv.

## `ToList` og `ToArray`

Mange LINQ-metoder returnerer ikke en `List<T>`, men en query, der kan itereres over.

Hvis du vil gemme resultatet som en liste:

```csharp
List<Produkt> itProdukter = produkter
    .Where(p => p.Kategori == "IT")
    .ToList();
```

Hvis du vil have et array:

```csharp
Produkt[] itProdukterArray = produkter
    .Where(p => p.Kategori == "IT")
    .ToArray();
```

Brug `ToList`, når du faktisk har brug for en liste. Kald det ikke automatisk efter hver LINQ-metode.

## Deferred execution

Mange LINQ-queries bliver først udført, når du itererer over resultatet eller kalder metoder som `ToList`, `Count`, `First` eller `Any`.

```csharp
List<int> tal = new() { 1, 2, 3 };

var query = tal.Where(t => t > 1);

tal.Add(4);

foreach (int t in query)
{
    Console.WriteLine(t);
}
```

Output:

```text
2
3
4
```

Det kan overraske. Queryen blev defineret før `4` blev tilføjet, men den blev først udført i `foreach`.

Hvis du vil låse resultatet fast med det samme, så brug `ToList`.

```csharp
var liste = tal.Where(t => t > 1).ToList();
```

## LINQ ændrer normalt ikke den oprindelige liste

Dette sorterer ikke selve listen:

```csharp
var sorteret = produkter.OrderBy(p => p.Pris);
```

`sorteret` er en ny sorteret sekvens. `produkter` ligger stadig i samme rækkefølge.

Hvis du vil gemme sorteringen:

```csharp
produkter = produkter
    .OrderBy(p => p.Pris)
    .ToList();
```

## Kæd LINQ-metoder sammen

En typisk LINQ-kæde kan se sådan ud:

```csharp
var resultat = produkter
    .Where(p => p.Lager > 0)
    .Where(p => p.Pris >= 100)
    .OrderBy(p => p.Kategori)
    .ThenByDescending(p => p.Pris)
    .Select(p => new
    {
        p.Navn,
        p.Kategori,
        p.Pris
    })
    .ToList();
```

Det er ofte bedre at have flere læsbare trin end at presse alt ind i én meget lang linje.

## LINQ med strings

LINQ virker også på tekst, fordi en string kan behandles som en samling af tegn.

```csharp
string tekst = "programmering";

var vokaler = tekst
    .Where(tegn => "aeiouyæøå".Contains(char.ToLower(tegn)))
    .ToList();

Console.WriteLine(vokaler.Count);
```

Du kan også bruge LINQ på en liste af navne:

```csharp
List<string> navne = new() { "Anna", "Bo", "Asta", "Carl", "Amir" };

var navneMedA = navne
    .Where(n => n.StartsWith("A"))
    .OrderBy(n => n);
```

## LINQ med filer

Hvis du har læst en fil ind som linjer, kan LINQ bruges til at filtrere og analysere dem.

```csharp
string[] linjer = File.ReadAllLines("log.txt");

var fejlLinjer = linjer
    .Where(linje => linje.Contains("ERROR"))
    .ToList();
```

Du kan også tælle:

```csharp
int antalAdvarsler = linjer.Count(linje => linje.Contains("WARNING"));
```

## `Dictionary` og LINQ

En dictionary kan også bruges med LINQ.

```csharp
Dictionary<string, int> point = new()
{
    ["Anna"] = 12,
    ["Bo"] = 7,
    ["Clara"] = 10
};

var topElever = point
    .Where(pair => pair.Value >= 10)
    .OrderByDescending(pair => pair.Value);

foreach (var elev in topElever)
{
    Console.WriteLine($"{elev.Key}: {elev.Value}");
}
```

I en dictionary er hvert element et key/value-par.

## Mini-projekt: produktfilter i konsollen

Lav et lille konsolprogram, hvor brugeren kan vælge en kategori og en minimumspris.

```csharp
Console.Write("Kategori: ");
string kategori = Console.ReadLine() ?? "";

Console.Write("Minimumspris: ");
decimal minimumspris = decimal.Parse(Console.ReadLine() ?? "0");

var fundneProdukter = produkter
    .Where(p => p.Kategori.Equals(kategori, StringComparison.OrdinalIgnoreCase))
    .Where(p => p.Pris >= minimumspris)
    .OrderBy(p => p.Pris)
    .ToList();

if (!fundneProdukter.Any())
{
    Console.WriteLine("Ingen produkter fundet.");
}
else
{
    foreach (Produkt produkt in fundneProdukter)
    {
        Console.WriteLine($"{produkt.Navn} - {produkt.Pris} kr.");
    }
}
```

Udvidelser:

- Lad brugeren søge på en del af produktnavnet
- Vis samlet lagerværdi for de fundne produkter
- Vis den billigste og dyreste vare i resultatet
- Gruppér resultatet efter kategori

## Typiske fejl at undgå

- At glemme `using System.Linq;`
- At bruge `First()` uden at være sikker på, at der findes et element
- At bruge `Single()` på data, hvor der måske findes flere matches
- At kalde `ToList()` for tidligt og for ofte
- At tro at `OrderBy()` ændrer den oprindelige liste
- At skrive for lange LINQ-kæder uden mellemvariable
- At bruge LINQ, når et almindeligt loop faktisk er mere læsbart

## Hurtig metodeoversigt

| Metode | Bruges til | Eksempel |
| --- | --- | --- |
| `Where` | Filtrere | `tal.Where(t => t > 5)` |
| `Select` | Omforme/vælge data | `personer.Select(p => p.Navn)` |
| `OrderBy` | Sortere stigende | `produkter.OrderBy(p => p.Pris)` |
| `OrderByDescending` | Sortere faldende | `produkter.OrderByDescending(p => p.Pris)` |
| `ThenBy` | Ekstra sortering | `.ThenBy(p => p.Navn)` |
| `First` | Første element, fejl hvis intet findes | `tal.First(t => t > 5)` |
| `FirstOrDefault` | Første element eller standardværdi | `personer.FirstOrDefault(p => p.Id == 1)` |
| `Any` | Findes der mindst ét? | `produkter.Any(p => p.Lager == 0)` |
| `All` | Matcher alle? | `produkter.All(p => p.Pris > 0)` |
| `Count` | Antal | `produkter.Count()` |
| `Sum` | Sum | `produkter.Sum(p => p.Pris)` |
| `Average` | Gennemsnit | `produkter.Average(p => p.Pris)` |
| `Min` | Mindste værdi | `produkter.Min(p => p.Pris)` |
| `Max` | Største værdi | `produkter.Max(p => p.Pris)` |
| `GroupBy` | Gruppere | `produkter.GroupBy(p => p.Kategori)` |
| `Distinct` | Fjerne dubletter | `navne.Distinct()` |
| `Contains` | Indeholder værdi | `ids.Contains(p.Id)` |
| `Skip` | Spring over | `.Skip(10)` |
| `Take` | Tag et antal | `.Take(10)` |
| `ToList` | Lav resultat til liste | `.ToList()` |
| `ToArray` | Lav resultat til array | `.ToArray()` |

## Øvelser

### Øvelse 1 - tal

Lav en liste med tallene 1 til 20.

Find med LINQ:

1. alle lige tal
2. alle tal større end 10
3. alle tal ganget med 3
4. summen af alle tal
5. gennemsnittet af alle tal

### Øvelse 2 - navne

Lav en liste med mindst 8 navne.

Find med LINQ:

1. navne der starter med `A`
2. navne der er længere end 5 tegn
3. navne sorteret alfabetisk
4. navne skrevet med store bogstaver
5. antal navne der indeholder bogstavet `e`

### Øvelse 3 - produkter

Lav en liste af produkter med `Navn`, `Pris` og `Kategori`.

Find med LINQ:

1. produkter med pris over 100
2. produkter sorteret efter pris
3. kun produktnavnene
4. den samlede pris for alle produkter
5. den dyreste vare
6. produkter grupperet efter kategori

### Øvelse 4 - elever

Lav en klasse:

```csharp
public class Elev
{
    public string Navn { get; set; } = "";
    public int Karakter { get; set; }
    public bool HarAfleveret { get; set; }
}
```

Lav en liste med mindst 6 elever.

Find med LINQ:

1. elever der har afleveret
2. elever der ikke har afleveret
3. elever med karakter på mindst 7
4. klassens gennemsnit
5. den højeste karakter
6. navnene på eleverne sorteret efter karakter fra højest til lavest

### Øvelse 5 - logfil

Lav en tekstfil eller en liste af strings med loglinjer:

```text
INFO Program startet
WARNING Lav diskplads
ERROR Kunne ikke gemme fil
INFO Program afsluttet
```

Find med LINQ:

1. alle linjer med `ERROR`
2. alle linjer med `WARNING`
3. antal `INFO`-linjer
4. alle linjer sorteret efter længde
5. kun beskedteksten uden niveauet først

## Ekstra udfordringer

1. Lav et søgefelt, hvor brugeren kan søge efter produkter med `Contains`.
2. Lav paging med `Skip` og `Take`.
3. Lav en statistikside, der viser antal, gennemsnit, min og max.
4. Lav en kategorioversigt med `GroupBy`.
5. Lav en metode, der modtager en liste af produkter og returnerer de 5 dyreste.
6. Lav en metode, der modtager en søgetekst og returnerer matchende produkter.
7. Lav en metode, der kan sortere produkter efter enten navn, pris eller lager.

## Facit-eksempel til produktøvelsen

```csharp
var produkterOver100 = produkter
    .Where(p => p.Pris > 100)
    .ToList();

var sorteretEfterPris = produkter
    .OrderBy(p => p.Pris)
    .ToList();

var produktNavne = produkter
    .Select(p => p.Navn)
    .ToList();

decimal samletPris = produkter.Sum(p => p.Pris);

Produkt dyreste = produkter
    .OrderByDescending(p => p.Pris)
    .First();

var grupperetEfterKategori = produkter
    .GroupBy(p => p.Kategori);
```

## Hvornår skal du vælge loop i stedet?

Brug gerne et almindeligt loop, hvis:

- du ændrer mange ting undervejs
- du har kompleks logik med mange trin
- du skal debugge hvert trin meget tydeligt
- LINQ-versionen bliver sværere at læse end loopet

Brug LINQ, hvis:

- du filtrerer data
- du sorterer data
- du vælger bestemte felter
- du laver simple beregninger
- du grupperer data
- du vil udtrykke "hvad" du leder efter mere end "hvordan" loopet skal køre

## Kort opsummering

LINQ handler om at stille spørgsmål til data.

De vigtigste metoder at kunne først er:

- `Where`
- `Select`
- `OrderBy`
- `FirstOrDefault`
- `Any`
- `Count`
- `GroupBy`
- `ToList`

Når du kan dem, kan du løse rigtig mange hverdagsproblemer i C#.
