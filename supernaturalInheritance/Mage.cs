class Mage : Pupil
{
    public Mage(string title): base(title)
    {}

    public virtual Storm CastRainStorm()
    {
        Storm magecast =new Storm("rain", false, Title);
        return magecast;
    }
}