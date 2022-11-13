// public Dictionary<string, double> legend = new Dictionary<string, double>();

OptimalChange(37.23, 93.75);
void OptimalChange(double cost, double paid){
    double change = Math.Round(paid - cost, 2);
    Dictionary <string, double> Legend = new Dictionary<string, double>();
    Legend.Add("100 Dollar Bill", 100.00);
    Legend.Add("50 Dollar Bill", 50.00);
    Legend.Add("20 Dollar Bill", 20.00);
    Legend.Add("10 Dollar Bill", 10.00);
    Legend.Add("5 Dollar Bill", 5.00);
    Legend.Add("Dollar Bill", 1.00);
    Legend.Add("Quarter", 0.25);
    Legend.Add("Dime", 0.10);
    Legend.Add("Nickle", 0.05);
    Legend.Add("Penny", 0.01);
    List <string> almost = new List<string>();
    foreach(var item in Legend){
        if(change>= item.Value){
            int count = (int)Math.Floor(change/item.Value);
            change = Math.Round(change%item.Value,2);
            string about;
            if (count > 1 && item.Key == "Penny"){
                about =$"{count} Pennie";
            }
            else{
                about= $"{count} {item.Key}";
            }
            if (count > 1){
                about+="s";
            }
            if (0.01 > change){
                about+=".";
            }
            if (almost.Count>1 && 0.01> change){
                about = $"and {about}";
            }
            almost.Add(about);
        }
    }
    string resultAlmost = String.Join(", ",almost.ToArray());
    Console.WriteLine($"The optimal change of an item that is ${Math.Round(cost,2)} paid with ${Math.Round(paid, 2)} is {resultAlmost}");
    
}

