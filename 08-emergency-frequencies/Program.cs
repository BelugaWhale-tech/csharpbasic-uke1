using System.Diagnostics.CodeAnalysis;

string signal = "YELLOW";

// TODO: Lag switch med kombinerte case-labels.

switch (signal)
{
    case "RED": case"CRIMSON": case"SCARLET":
        Console.WriteLine("Evacuate deck");
        break;
    case "AMBER": case"YELLOW":
        Console.WriteLine("prepare crew");
        break;
    case "GREEN":
        Console.WriteLine("No emergency");
        break;
    default:
        Console.WriteLine("Unknow signal");
        break;        
}