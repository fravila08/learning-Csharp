Console.WriteLine("This is a Pupil");
Pupil zul= new Pupil("Mezil-kree");
Storm zulcast = zul.CastwindStorm();
Console.WriteLine(zulcast.Announce());
Console.WriteLine("\n \nThis is a mage");
Mage gul = new Mage("Gul'dan");
Storm gulcast = gul.CastRainStorm();
Console.WriteLine(gulcast.Announce());
Console.WriteLine("\n \nThis is an Archmage");
Archmage nie = new Archmage("Nielas Aran");
Storm[] spells = new Storm[2];
spells[0]=nie.CastLightningStorm();
spells[1]=nie.CastRainStorm();
foreach (Storm cast in spells){
    Console.WriteLine(cast.Announce());
}
