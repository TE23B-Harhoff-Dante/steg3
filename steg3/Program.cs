// 1 
static void hello32()
{
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine("hello, World!");
    }
}

hello32();

// 2
static void GR(int kvadraten)
{
    Console.WriteLine(kvadraten * kvadraten);
}
Console.WriteLine("Vilken siffra vill du ha kvadraten av?");
int k = GetNumberInput();
GR(k);

// 3
static float Multi(float x, float y)
{
    return x * y;
}

float x = GetNumberInput();
float y = GetNumberInput();
float r = Multi(x, y);
Console.WriteLine(r);

// 4
static float triangel(float b, float h)
{
    return (b * h) / 2;
}
float b = GetNumberInput();
float h = GetNumberInput();
float r2 = triangel(b, h);
Console.WriteLine(r2);

// 5
static float cirkel(float radie)
{
    return (radie * radie) * 3.14f;
}

int t = GetNumberInput();
float r3 = cirkel(t);
Console.WriteLine(r3);

// 6
static int GetNumberInput()
{
    //Skapa en loop inuti metoden som inte avslutas förrän användaren skrivit in något som är ett tal.
    bool isANumber = false;
    int number1 = 0;
    while (isANumber == false)
    {
        string siffra2 = Console.ReadLine();
        isANumber = int.TryParse(siffra2, out number1);
    }

    return number1;
}



























Console.ReadLine();