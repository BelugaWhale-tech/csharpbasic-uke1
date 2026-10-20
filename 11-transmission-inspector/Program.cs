string transmission = "CLEAR";
int interferenceCount = 0;

// TODO: Bruk foreach over transmission.

foreach(char i in transmission)
{
    if (i=='#')
    interferenceCount ++;
}


Console.WriteLine($"Interference markers: {interferenceCount}");
