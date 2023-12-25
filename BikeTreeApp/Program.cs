// Build a tree structure representing the bike assembly
using BikeTreeApp;

Node bike = new Node("Bike", int.MaxValue);
Node seat = new Node("Seat", 50);
Node pedals = new Node("Pedals", 60);
Node wheels = new Node("Wheels", int.MaxValue);
Node frame = new Node("Frame", 60);
Node tube = new Node("Tube", 35);

wheels.Children = new Node[] { frame, tube };
bike.Children = new Node[] { seat, pedals, wheels };

// Calculate the maximum number of bike bundles that can be built
int maxBundles = bike.CalculateMaxBundles(1);

// Display the result to the user
Console.WriteLine($"You can build a maximum of {maxBundles} complete bike bundles with the available parts.");

