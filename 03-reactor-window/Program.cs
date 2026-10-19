int energy = 39;
int stableLow  = 40;
int stableHigh = 70;

// TODO: Energy må være mellom 40 og 70, inklusive.
bool isStable = energy>stableLow && energy<stableHigh;

Console.WriteLine($"Reactor stable: {isStable}");
