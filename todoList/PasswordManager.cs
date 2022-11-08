class PasswordManager: IDisplay, IResetable
  {
    private string Password
    { get; set;}

    public bool Hidden
    { get; protected set; }

    public string HeaderSymbol
    {
        get;
    }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
      HeaderSymbol="Password \n----------";
    }
    public void Display()
    {
        if (Hidden == false){
            Console.WriteLine(Password);
        }
        else{
            string[] hiddenPassword= new string[Password.Length];
            for (int i=0; i< hiddenPassword.Length ; i++){
                hiddenPassword[i]= "*";
            }
            string result = String.Join("", hiddenPassword);
            Console.WriteLine(result);
        }
    }
    public void Reset()
    {
        Password = "";
        Hidden = false;
    }
    public bool ChangePassword(string old, string neew)
    {
        if (Password == old){
            Password = neew;
            return true;
        }
        else{
            return false;
        }
    }
    public void MakeVisable()
    {
        if (Hidden == true){
            Hidden = false;
        }
        else{
            Hidden= true;
        }
    }
  }