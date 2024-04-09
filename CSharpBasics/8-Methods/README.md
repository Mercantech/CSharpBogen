# Metoder

## Hvad er en metode?

En metode er en samling af instruktioner, der udfører en bestemt opgave. Metoder bruges til at organisere kode, gøre den genanvendelig og nemmere at vedligeholde.

## Hvorfor bruger vi metoder?

Metoder hjælper med at opdele komplekse opgaver i mindre, mere håndterbare dele. Dette gør koden mere modulær og lettere at forstå. Når du skriver kode, kan du kalde en metode i stedet for at gentage den samme kode flere gange, hvilket reducerer redundans og forbedrer vedligeholdelsen.

## Hvordan defineres en metode?

En metode har normalt følgende dele:

1. **Metodenavn**: Et navn, der identificerer metoden og bruges til at kalde den fra andre steder i koden.

2. **Parametre**: Parametre er værdier, der sendes til metoden, så den kan udføre sin opgave. Parametre er valgfrie, og en metode kan have nul, en eller flere parametre.

3. **Returneringsværdi**: Nogle metoder returnerer en værdi som resultat af deres udførelse. Dette er valgfrit, og en metode kan også være `void`, hvilket betyder, at den ikke returnerer nogen værdi.

4. **Krop**: Dette er selve kodens blok, der indeholder de instruktioner, der skal udføres, når metoden kaldes.

## Eksempel på en metode:

Her er et eksempel på en simpel metode i C#, der tager to tal som parametre, udfører en simpel beregning og returnerer resultatet:

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
}
```

I dette eksempel:

- `public int Add(int a, int b)` er metodesignaturen, hvor Add er navnet på metoden, int angiver, at metoden returnerer en integer-værdi, og (int a, int b) er parametrene, der modtages af metoden.

- `int sum = a + b;` udfører en simpel addition af parametrene a og b.

- `return sum;` returnerer summen som resultat af metoden.

### Hvordan bruger man en metode?

Når metoden er defineret, kan den kaldes fra andre dele af koden ved at angive dens navn og eventuelle nødvendige parametre. Her er et eksempel på, hvordan du kan kalde `Add`-metoden fra `Calculator`-klassen:

```csharp
Calculator calculator = new Calculator();
int result = calculator.Add(5, 3);
Console.WriteLine("Result: " + result); // Output: Resultat: 8
```

Dette kalder `Add`-metoden med værdierne 5 og 3 som parametre og udskriver resultatet, som er 8.

## Metoder eller Funktioner

### Metoder:

- Metoder er kodeblokke, der er indeholdt i en klasse eller en struktur i C#. De har en relation til objektet af denne klasse eller struktur.
- Metoder i C# kan have en [synlighedsmodifierer](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers), f.eks. public, private, protected, eller internal, hvilket bestemmer, hvilken del af koden der har adgang til dem.
- En metode er normalt relateret til en klasse, og dens indhold er ofte afhængig af dataene indeholdt i instanserne af den pågældende klasse.
- Metoder kan returnere en værdi ved hjælp af en return-erklæring eller være void (dvs. ikke returnere noget).
- Eksempel: `public void DoSomething() { ... }`

### Funktioner:

- Funktioner er en mere generel betegnelse, der ofte refererer til kodeblokke, der udfører en bestemt opgave eller beregning.
- I C# kan funktioner forekomme både inden og uden for klasser. Funktioner, der findes uden for klasser, er normalt statiske og bruges som hjælpefunktioner.
- Funktioner kan kaldes uafhængigt af en klasseinstans og kan returnere en værdi eller være void.
- Eksempel: `public static int Add(int a, int b) { return a + b; }`

### Forskel:

Den primære forskel mellem metoder og funktioner i C# er i konteksten, hvor de er defineret og brugt:

- Metoder er tæt knyttet til klasser og bruges til at beskrive objekters opførsel.
- Funktioner kan eksistere uafhængigt af klasser og bruges mere generelt til at udføre opgaver eller beregninger.

Generelt bruger vi mest Metoder, når vi programmere objekt orienteret, dog gør det ikke så meget om man kommer til at kalde dem Funktioner i stedet
