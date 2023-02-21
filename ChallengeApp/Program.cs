int number = 928911;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;


foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}
Console.WriteLine("Liczba " + (number) + " zawiera:");

Console.WriteLine("Cyfrę '0' -> " + counter0 + " razy ");
Console.WriteLine("Cyfrę '1' -> " + counter1 + " razy ");
Console.WriteLine("Cyfrę '2' -> " + counter2 + " razy ");
Console.WriteLine("Cyfrę '3' -> " + counter3 + " razy ");
Console.WriteLine("Cyfrę '4' -> " + counter4 + " razy ");
Console.WriteLine("Cyfrę '5' -> " + counter5 + " razy ");
Console.WriteLine("Cyfrę '6' -> " + counter6 + " razy ");
Console.WriteLine("Cyfrę '7' -> " + counter7 + " razy ");
Console.WriteLine("Cyfrę '8' -> " + counter8 + " razy ");
Console.WriteLine("Cyfrę '9' -> " + counter9 + " razy ");
