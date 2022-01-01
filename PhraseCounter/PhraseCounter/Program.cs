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





