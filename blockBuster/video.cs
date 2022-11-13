

// [Serializable]
public class Videos
{
    public string Id{get;  set;}
    public string Title{get;  set;}
    public string Rating{get;  set;}
    public string Year{get;  set;}
    public string Copies{get; set;}
    public Videos(string id, string title, string rating, string year, string copies)
    {
        Id=id;
        Title=title;
        Rating=rating;
        Year=year;
        Copies=copies;
    }

    public static List <Videos> allvideos= new List<Videos>();

    public static void AddVideo(Videos instance)
    {   
        allvideos.Add(instance);
    }

    public static Videos GetAVideo(string enteredTitle){
        foreach(Videos video in allvideos){
            if(video.Title == enteredTitle){
                return video;
            }
        }
        throw new NullReferenceException("This video does not exist");
    }
    public static bool VideoExist(string enteredTitle)
    {
        foreach(Videos video in allvideos){
            if(video.Title == enteredTitle){
                return true;
            }
        }
        return false;
    }
}