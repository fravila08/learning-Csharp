class TodoList : IDisplay, IResetable
  {
    public string[] Todos
    { get; private set; }

    public string HeaderSymbol
    {get;}

    private int nextOpenIndex;

    public TodoList() 
    {
      Todos = new string[5];
      nextOpenIndex = 0;
      HeaderSymbol= "Todos \n----------";
    }

    public void Add(string todo)
    {
        if (nextOpenIndex < 5){
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }
        else{
            Console.WriteLine("Your todo list is full");
        }
    }

    public void Display()
    {
        for (int i=0; i< Todos.Length; i++){
            if(String.IsNullOrEmpty(Todos[i])){
                Console.WriteLine($"{i+1}. item:[]");
            }
            else{
                Console.WriteLine($"{i+1}. item: {Todos[i]}");
            }
        }
    }
    public void Reset()
    {
        Todos= new String[5];
        nextOpenIndex= 0;
    }
  }