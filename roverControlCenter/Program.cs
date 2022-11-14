
MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
MoonRover apollo = new MoonRover("Apollo 15", 1971);
MarsRover sojourner = new MarsRover("Sojourner", 1997);
Satellite sputnik = new Satellite("Sputnik", 1957); 
Rover[] rovers = {lunokhod, apollo, sojourner};
IDirectable[] probes = {lunokhod, apollo, sojourner, sputnik};
DirectAll(probes);
// foreach(IDirectable probe in probes){
//     Console.WriteLine($"Tracking a {probe.GetType()}");
// }

void DirectAll(IDirectable[] array)
{
    foreach(IDirectable rove in array){
        Console.WriteLine(rove.GetInfo());
        Console.WriteLine(rove.Explore());
        Console.WriteLine(rove.Collect());
    }
}