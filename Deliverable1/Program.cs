
Console.WriteLine("Welcome to the restocking tool.");

int sodaStk = 100;
int sodeRestk = 40;

int chipsStk = 40;
int chipsRestk = 20;

int candyStk = 60;
int candyRestk = 40;

Console.WriteLine("How many sodas have been sold today? (100 in stock): ");
int sodaSold = int.Parse(Console.ReadLine());

if (sodaSold <= sodaStk)
{
    sodaStk -= sodaSold;
}
else
{
    Console.WriteLine("Too High");
}


Console.WriteLine("How many chips have been sold today? (40 in stock)");
int chipsSold = int.Parse(Console.ReadLine());

if (chipsSold <= chipsStk)
{
    chipsStk -= chipsSold;
}
else
{
    Console.WriteLine("Too high");
}


Console.WriteLine("How many candies have been sold today? (60 in stock): ");
int candiesSold = int.Parse(Console.ReadLine());

if (candiesSold <= candyStk)
{
    candyStk -= candiesSold;
}
else
{
    Console.WriteLine("Too high");
}



if (sodaStk <= sodeRestk)
{
    Console.WriteLine("Soda needs to be restocked.");
}
if (chipsStk <= chipsRestk)
{
    Console.WriteLine("Chips needs to be restocked.");
}

if (candyStk <= candyRestk)
{
    Console.WriteLine("Candy needs to be restocked.");
}
