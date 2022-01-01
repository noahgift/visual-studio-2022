# visual-studio-2022
Notes on VS 2022

## Setup

* Add visualstudio `.gitignore`

## Build a Console App 

* [Code Here](https://github.com/noahgift/visual-studio-2022/blob/main/PhraseCounter/PhraseCounter/Program.cs)

```csharp
// Declare variable
int count = 0;

// Display title
Console.WriteLine("Phrase Generator" + Environment.NewLine);

// Ask for phrase
Console.WriteLine("What phrase would you like to repeat?" + Environment.NewLine);
var phrase = Console.ReadLine();

// Ask for phrase count
Console.WriteLine("How many times do you want to repeat the phrase?" + Environment.NewLine);
count = Convert.ToInt32(Console.ReadLine());

// Loop the phrase
Console.WriteLine($"Repeating [PHRASE] {phrase} for [COUNT] {count}" + Environment.NewLine);
for (int i = 0; i < count; i++)
{
    Console.Write($"{phrase}" + Environment.NewLine);
}

```


## Reference

* [Tutorial VS 2022](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-editor?view=vs-2022)
