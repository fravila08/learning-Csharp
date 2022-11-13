// using LINQtoCSV;
Store m = new Store("blockbuster");
bool runner=true;
Console.WriteLine($"Welcome to {m.Name}!");
while(runner){
    Console.WriteLine($"Please choose an option below:\n     1.View Inventory\n     2.View Your Information\n     3.Rent A Video\n     4.Return A Video\n     5.Create A Customer\n     6.QUIT\n---enter a number for your option---");
    string choice=Console.ReadLine();
    char[] trueChoice= choice.ToCharArray();
    char myChoice = trueChoice[0];
    if(myChoice == '1'){
        m.ListAllVideos();
    }
    if (myChoice == '2'){
        m.SeeMyDetails();
    }
    if(myChoice == '3'){
        m.RentAVideo();
    }
    if (myChoice=='4'){
        m.ReturnAVideo();
    }
    if(myChoice=='5'){
        m.CreateAClient();
    }
    if(myChoice == '6'){
        Console.WriteLine("Come back soon!");
        runner= false;
    }
}


