# <img src="./Assets/Images/CSharp.png" alt="CSharpLogo" width="30"/> **- Bogen**

C# bogen - Start med at lære C# og grundlæggende programmerings termer. Bogen her indeholder både teori, eksempler, videoer og opgaver til at lære omkring **C#**!

<table>
        <tr>
          <th width='650'>Ekstra materiale</th>
          <th>Links</th>
        </tr>
        <tr>
          <td align="center">
                <p> Powerpoint-slides </p> 
                <p> Her er slides som bliver gennemgået på klassen opdelt efter mapperne her på GitHub! </p> 
          </td>
          <td align="center"> <a href="https://edumercantec-my.sharepoint.com/:f:/g/personal/mags_edu_mercantec_dk/Erl8BqaZxR5LjE4bwFzvrZMB9Yd3dp60nhfy2xLTSq3pZg?e=TvCShM"><img src='https://github.com/MAGS-Template/README-Assets/blob/main/Microsoft-PowerPoint-Logo.png?raw=true' width='200'></a></td>
        </tr>
        <tr>
          <td align="center">
                  <p>Notion dokumentation og guide</p>
                  <p>På Notion er der ekstra dokumentation og matrialle. Vi har generelt alt information på Notion, så man kan også finde meget andet end C# dokumentation! </p>
          </td>
          <td align="center"> <a href="https://mercantec.notion.site/API-i-NET-746a499da4b9489893449834869da4ca?pvs=74"><img src='https://github.com/MAGS-Template/README-Assets/blob/main/Notion_app_logo.png?raw=true' width='100'></a></td>
        </tr>
        <tr>
          <td align="center" style="color: red;" >
                <p>Video guide [TBA] </p>
                <p>Vi prøver at video dokumentere vores pensum, det er en løbende process, men det burde gøre det nemmere, hvis man er mere til video formattet end selv at læse! </p>
          </td>
          <td align="center"> <a href="https://www.youtube.com/playlist?list=PL7-jfBWeCNfwlbjdpc_R3EIJYmZ-Q-qAu"><img src='https://github.com/MAGS-Template/README-Assets/blob/main/Youtube.png?raw=true' width='100'></a></td>
        </tr>
</table>

## [Visual Studio](./VisualStudio)

Vi bruger Visual Studio på de fleste af vores hovedforløb, det er den oplagte IDE til C# og .NET udvikling!

 <img src="./Assets/Images/Visual-Studio-Community-Banner.webp" alt="CSharpLogo" width="1200"/>

I kommer til at få en gennemgang med opsætning og en kort gennemgang af selve programmet (De er begge også på [Youtube](https://www.youtube.com/playlist?list=PL7-jfBWeCNfwlbjdpc_R3EIJYmZ-Q-qAu)). I har arbejdet i en IDE før, såsom VSCode, så det burde ikke være helt nyt for jer!

## [C#-Basics](./CSharpBasics)

### 1. [Dit første program - Main(string[] args)](/CSharpBasics/1-FirstProgram/)

- Vi har en standart konsol app i C#, vi skal starte med at forstå programmet før vi kan skrive i det!

```c#
  namespace FirstProgram
  {
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej og velkommen til H1!");
        }
    }
  }
```

### 2. [Variabler](/CSharpBasics/2-Variables/)

Variabler i C# er brugt til at gemme og manipulere data. En variabel kan være en bestemt type, f.eks. et heltal, en streng eller en boolean værdi.

For at erklære en variabel i C#, skal du angive dens type og give den et navn. For eksempel kan du erklære en variabel af typen `int` (heltal) ved at skrive:

```csharp
int nummer;

```

Her har vi erklæret en variabel ved navn `nummer` af typen `int`. Du kan også initialisere variablen med en startværdi ved at tildele den en værdi. For eksempel:

```csharp
int alder = 25;

```

### 3. [Expressions og Operatøre](/CSharpBasics/3-Expressions&Operators/)

### 4. [Array & Lister](/CSharpBasics/4-Arrays&Lists/)

I C# bruges arrays til at gemme og håndtere en samling af elementer af samme type. En array er en datastruktur, der giver mulighed for at gemme flere værdier i en enkelt variabel.

For at oprette en array i C#, skal du angive typen af elementer, der skal gemmes i arrayet, og derefter angive størrelsen på arrayet. For eksempel kan du oprette en array af heltal med ti elementer ved at skrive:

```csharp
int[] numbers = new int[10];

```

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

### 5. [Control Flow](/CSharpBasics/5-ControlFlow/)

I C# er conditionals en vigtig del af programmering, der giver dig mulighed for at udføre forskellige handlinger baseret på en bestemt betingelse. Du kan bruge forskellige typer conditionals i C#, herunder if, else, switch og ternary operator. Vi reffere også til det som kontrol flow, for vi kontrollere flowet af vores kode ud fra nogle betingelser (conditionals)

#### If Statement

If statement (hvis-udtalelse) er den mest grundlæggende form for conditional i C#. Det giver dig mulighed for at udføre en bestemt kodeblok, hvis en betingelse er sand. Hvis betingelsen er falsk, springes kodeblokken over.

Her er syntaksen for en if statement:

```csharp
if (betingelse)
{
    // Kode, der skal udføres, hvis betingelsen er sand
}

```

### 6. [Objekter](/CSharpBasics/6-Objects/)

### 7. [Loops & iterationer](/CSharpBasics/7-Loops&Iterations/)

### 8. [Metoder](/CSharpBasics/8-Methods/)

### 9. [Debugging](/CSharpBasics/9-Debugging/)

```

```
