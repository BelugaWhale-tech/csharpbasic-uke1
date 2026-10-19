bool hasSuit = true;
int oxygenPercent = 45;
int pressure = 95;
bool alarmActive = false;

// TODO: Kombiner alle kravene i ett logisk uttrykk.
bool canOpenAirlock = false;

if (!canOpenAirlock && hasSuit && oxygenPercent >=30 && pressure >=90 && pressure <=110 && !alarmActive)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
