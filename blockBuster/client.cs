public class Client
{
    public string Id{get;set;}
    public string Account{get;set;}
    public string Name{get;set;}
    public List<string> CurrentRentals{get;set;}
    
    public Client(string id, string account, string name, List<string> rentals)
    {
        Id=id;
        Account= account;
        Name= name;
        CurrentRentals=rentals;
    }

    public static List <Client> allClients= new List<Client>();
    public static void AddClient(Client instance)
    {   
        allClients.Add(instance);
    }

    public static Client ReturnAClient(char id)
    {
        string trueId = id.ToString();
        foreach (Client customer in allClients)
        {
            if(customer.Id == trueId){
                return customer;
            }
        }
        return allClients[0];
    }
    public static bool ValidId(char id)
    {
        string trueId = id.ToString();
        foreach (Client customer in allClients)
        {
            if(customer.Id == trueId){
                return true;
            }
        }
        return false;
    }
    
}