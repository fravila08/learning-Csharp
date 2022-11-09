class Archmage : Mage
{
    public Archmage(string title): base(title)
    {}

    public override Storm CastRainStorm()
    {
        Storm archmagecast= new Storm("rain", true, Title);
        return archmagecast;
    }

    public Storm CastLightningStorm(){
        Storm archLightningCast = new Storm("lightning", true, Title);
        return archLightningCast;
    }
}