# LINQ i C#

LINQ står for **Language Integrated Query** og gør det nemt at søge, filtrere og transformere data direkte i C#.

## Hvorfor LINQ?

LINQ giver:

- mindre boilerplate-kode
- bedre læsbarhed
- stærk typesikkerhed
- samme tankegang på tværs af arrays, lister og databaser

## Simpelt eksempel med `Where` og `Select`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

List<int> tal = new() { 1, 2, 3, 4, 5, 6 };

var ligeTalDobbelt = tal
    .Where(t => t % 2 == 0)
    .Select(t => t * 2);

foreach (var t in ligeTalDobbelt)
{
    Console.WriteLine(t);
}
```

Resultat:

- 4
- 8
- 12

## De mest brugte LINQ-metoder

- `Where` → filtrerer elementer
- `Select` → projekterer/ændrer elementer
- `OrderBy` / `OrderByDescending` → sorterer
- `First` / `FirstOrDefault` → henter første element
- `Any` / `All` → tjekker betingelser
- `GroupBy` → grupperer data
- `Distinct` → fjerner dubletter

## Query syntax vs method syntax

### Method syntax (mest brugt)

```csharp
var voksneNavne = personer
    .Where(p => p.Alder >= 18)
    .Select(p => p.Navn);
```

### Query syntax

```csharp
var voksneNavne =
    from p in personer
    where p.Alder >= 18
    select p.Navn;
```

Begge gør det samme – method syntax er typisk mest udbredt i moderne kode.

## Deferred execution

Mange LINQ-queries bliver først udført, når du **itererer** over resultatet (fx i `foreach`) eller kalder metoder som `ToList()`.

```csharp
var query = tal.Where(t => t > 3); // Ingen eksekvering endnu
var liste = query.ToList();         // Eksekvering sker her
```

## Typiske fejl at undgå

- At glemme `using System.Linq;`
- At bruge `First()` uden at være sikker på, at der er et element
- At kalde `ToList()` for tidligt og for ofte
- At skrive for lange LINQ-kæder uden mellemvariable

## Øvelse

1. Lav en liste af produkter med `Navn`, `Pris` og `Kategori`.
2. Filtrér produkter med pris over 100.
3. Sortér dem efter pris.
4. Vælg kun navnene.
5. Prøv også at gruppere på kategori med `GroupBy`.
