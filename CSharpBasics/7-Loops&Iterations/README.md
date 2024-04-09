# Loops og Iterationer i C#

Loops og iterationer er vigtige i programmering og I kommer til at bruge dem meget, vi kan generelt gøre vores kode meget mindre og reducere tiden det tager for at ændre elementer. I C# er der flere typer loops som vi kigger på, inklusiv `for`, `while`, `do-while` og `foreach`.

## 1. `for` loop

`for` loop bruges, når antallet af iterationer er kendt på forhånd.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}
```

## 2. `while` loop

while loop bruges, når du vil gentage en blok kode, så længe en betingelse er sand.

```csharp
int n = 0;
while (n < 5)
{
    Console.WriteLine("Iteration: " + n);
    n++;
}
```

## 3. `do-while` loop

do-while loop minder om while loop, men den tjekker betingelsen efter udførelsen af loopens kode, så det sikrer mindst én iteration.

```csharp
int m = 0;
do
{
    Console.WriteLine("Iteration: " + m);
    m++;
} while (m < 5);
```

## 4. `foreach` loop

foreach loop bruges primært til at iterere over elementer i en samling såsom arrays eller lister.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int num in numbers)
{
    Console.WriteLine("Number: " + num);
}
```

```csharp
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

foreach (int num in numbers)
{
    Console.WriteLine("Number: " + num);
}
```

Det er de mest grundlæggende loop-typer i C#. Afhængigt af programmets krav kan du vælge den mest passende loop-type for at opnå den ønskede funktionalitet. Vi skal generelt vælge ud fra læsbar hed og hvilken datatype vi arbejder med!
