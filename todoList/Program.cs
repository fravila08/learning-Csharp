class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      Console.WriteLine(tdl.HeaderSymbol);
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");
      tdl.Display();
      tdl.Reset();
      Console.WriteLine("After Reset function is called");
      tdl.Display();

      PasswordManager pm = new PasswordManager("iluvpie", true);
      Console.WriteLine(pm.HeaderSymbol);
      pm.Display();
      if(pm.ChangePassword("iluvpie", "iwantpie")){
        Console.WriteLine("Password Change was successful");
      }
      else{
        Console.WriteLine("Failed to confirm existing password");
      }
      pm.MakeVisable();
      pm.Display();
    }
  }