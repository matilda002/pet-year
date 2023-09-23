// getting the file and crating an array
string[] list = File.ReadAllLines("../../../pets.csv");

// making a dictonary
Dictionary<string, int> petYear = new Dictionary<string, int>();

foreach (string word in list)
{
    string[] convert = word.Split(";"); // making a new list and splitting the words thar have ; in between them
    if (int.TryParse(convert[1], out int age)) // omvandlar string till int
    {
        petYear.Add(convert[0], age); // inserrt name (the key) and the new int (age)
    }
}

Console.Write("Input a name to see their birthyear:  ");
var choice = Console.ReadLine().ToLower();

switch (petYear.ContainsKey(choice))
{
    case true:
        Console.WriteLine("Their birthyear is the yer:  " + petYear[choice]);
        break;
    case false:
        Console.WriteLine("We have no information under that name!");
        break;
}