public class Store 
{
    public string Name{get; private set;}
    public static string MyVideos{get;set;}
    public static string MyClients{get;set;}
    public Store(string name)
    {
        Name=name;
        MyVideos=ReadCSV("inventory");
        MyClients=ReadCSV("customers");
    }
    public static string ReadCSV(string argument)
    {
        string[] csvLines=System.IO.File.ReadAllLines($"./data/{argument}.csv");
        for(int i=1 ;i<csvLines.Length; i++){
            string[] row = csvLines[i].Split(',');
            if (argument == "inventory"){
                Videos instance = new Videos(row[0], row[1], row[2], row[3], row[4]);
                Videos.AddVideo(instance);
            }
            else if(argument == "customers"){
                List <string> videos = new List<string>();
                string[] rentals = row[4].Split('/');
                foreach(string rental in rentals){
                    videos.Add(rental);
                }
                Client instance = new Client(row[0], row[1], $"{row[2]} {row[3]}", videos);
                Client.AddClient(instance);
            }
        }
        return "success";
    }
    public string ListAllVideos()
    {
        foreach (Videos video in Videos.allvideos)
        {
            Console.WriteLine($"Title: {video.Title} --- Copies: {video.Copies}");
        }
        return "success";
    }
    public void SeeMyDetails()
    {
        Console.WriteLine("Enter your ID:\n");
        string enteredId=Console.ReadLine();
        char[] turningIdtoChar=enteredId.ToCharArray();
        char id=turningIdtoChar[0];
        Client customer = Client.ReturnAClient(id);
        Console.WriteLine($"Name: {customer.Name}\nAccount Type: {customer.Account}\nCurrent Rentals:");
        if(customer.CurrentRentals.Count > 0){
            int i = 1;
            foreach(string rental in customer.CurrentRentals){
                Console.WriteLine($"{i}. {rental}");
                i=i+1;
            }
        }
        else{
            Console.WriteLine("You currently have no videos rented.");
        }
    }
    public void RentAVideo()
    {
        Console.WriteLine("Enter your ID:\n");
        string enteredId=Console.ReadLine();
        char[] turningIdtoChar=enteredId.ToCharArray();
        char id=turningIdtoChar[0];
        Client customer = Client.ReturnAClient(id);
        if(customer.CurrentRentals.Count >0){
            Console.WriteLine("Your current rentals are:");
            foreach(string rental in customer.CurrentRentals){
                Console.WriteLine(rental);
            }
        }
        else{
            Console.WriteLine("You currently have no video rentals.");
        }
        Console.WriteLine("Current Inventory:");
        ListAllVideos();
        Console.WriteLine("What video would you like to rent out?(Please enter title)\n");
        string enteredTitle = Console.ReadLine();
        Videos video = Videos.GetAVideo(enteredTitle);
        Console.WriteLine($"Is this the video you are looking for?\n Title: {video.Title} Copies: {video.Copies}\n(enter Yes or No)");
        string confirm = Console.ReadLine();
        if (confirm == "Yes"){
            string number= video.Copies;
            int available;
            bool success;
            success= Int32.TryParse(number,out available);
            // Console.WriteLine(number);
            if(available > 0){
                customer.CurrentRentals.Add(video.Title);
                available-=1;
                video.Copies= available.ToString(); 
                Console.WriteLine($"{video.Title} has been rented out.");
            }
            else if (available ==0){
                Console.WriteLine("--This title has no copies available--");
            }
        }
        else if(confirm == "No"){
            Console.WriteLine("good on No");
        }
    }
    public void ReturnAVideo()
    {
        Console.WriteLine("Enter your ID:\n");
        string enteredId=Console.ReadLine();
        char[] turningIdtoChar=enteredId.ToCharArray();
        char id=turningIdtoChar[0];
        Client customer = Client.ReturnAClient(id);
        if (customer.CurrentRentals.Count > 0){
            Console.WriteLine("Your current rentals are:");
            foreach(string rental in customer.CurrentRentals){
                Console.WriteLine(rental);
            }
            Console.WriteLine("What title are you returning?\n");
            string enteredTitle = Console.ReadLine();
            Videos video = Videos.GetAVideo(enteredTitle);
            Console.WriteLine($"You are returning {video.Title}? (Yes or No)\n");
            string choice = Console.ReadLine();
            if(choice == "Yes"){
                customer.CurrentRentals.Remove(enteredTitle);
                int avail;
                bool success = Int32.TryParse(video.Copies, out avail);
                avail += 1;
                video.Copies = avail.ToString();
                Console.WriteLine($"{video.Title} has been returned, thank you.");
            }
        }
        else{
            Console.WriteLine("You currently have no videos rented out");
        }
    }
    public void CreateAClient()
    {
        int creatingId = Client.allClients.Count + 1;
        string id= creatingId.ToString();
        Console.WriteLine("Enter your first and last name:\n");
        string name= Console.ReadLine();
        Console.WriteLine("Choose your account type:\n(sx,px,sf,pf)");
        string account = Console.ReadLine();
        List <string> rentals = new List<string>();
        Client newClient= new Client(id, account, name, rentals);
        Client.AddClient(newClient);
        Console.WriteLine($"Congratulations your account has been created.\nYour new custmer ID is: {newClient.Id}");
    }
}