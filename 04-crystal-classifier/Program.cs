int energy = 81;
string classification = "";

// TODO: Sett classification med if / else if / else.

if (energy  <20)
{
    classification = "dormant";
}
else if (energy >=20 && energy <= 49)
{
    classification="stable";
}
else if(energy >=50 &&  energy <=79)
{
    classification="unstable";
}
else if (energy >= 80)
{
    classification="Critical";
}

Console.WriteLine($"Classification: {classification}");
