int cargoWeight = 803;
int maxWeight = 800;
int containerCount = 0;
int expectedContainers = 5;

// TODO: Erstatt false med riktige sammenligningsuttrykk.
bool isOverweight = cargoWeight>maxWeight;
bool isExactlyAtLimit = maxWeight==cargoWeight;
bool hasContainers = containerCount == expectedContainers;
bool countDiffersFromExpected = expectedContainers != containerCount;

Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");
