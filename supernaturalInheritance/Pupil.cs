class Pupil
{
    public string Title
    {get; private set;}

    public Pupil(string title)
    {
        Title = title;
    }

    public Storm CastwindStorm()
    {
        Storm pupilStorm = new Storm("wind", false, Title);
        return pupilStorm;
    }
}