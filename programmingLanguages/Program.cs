using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();
      // foreach(var language in languages){
        // Console.WriteLine(language.Prettify());
      // }
      // PrettyPrintAll(languages);
      var baseInfo = languages.Select(lang=> $"Year: {lang.Year} Name: {lang.Name} Chief: {lang.ChiefDeveloper} ");
      // foreach( var lang in baseInfo){
      //   Console.WriteLine(lang);
      // }
      // PrintAll(baseInfo);
      var csharplang= languages.Where(lang=> lang.Name == "C#");
      // foreach (var sharp in csharplang){
      //   Console.WriteLine(sharp.Prettify());
      // }
      // PrettyPrintAll(csharplang);
      var microLangs= languages.Where(lang=> lang.ChiefDeveloper.Contains("Microsoft"));
      // foreach(var mic in microLangs){
      //   Console.WriteLine(mic.Prettify());
      // }
      PrettyPrintAll(microLangs);
      // var legacy= languages.Where(lang=> lang.Predecessors.Contains("Lisp"));
      // foreach(var leg in legacy){
      //   Console.WriteLine(leg.Prettify());
      // }
      var scripts = languages.Where(lang=>lang.Name.Contains("Script"));
      // foreach(var lang in scripts){
      //   Console.WriteLine(lang.Prettify());
      // }
      // PrettyPrintAll(scripts);
      // var counter = languages.Count();
      // Console.WriteLine(counter);
      var dateCounter= languages
        .Where(lang=> lang.Year >= 1995 && lang.Year <= 2005)
        .Select(lang=> $"{lang.Name} was invented in {lang.Year}");
      // // Console.WriteLine(dateCounter.Count());
      // foreach(var lang in dateCounter){
      //   Console.WriteLine(lang);
      // }
      // PrintAll(dateCounter);

    }
    public static void PrettyPrintAll(IEnumerable<Language> langs){
      foreach(var lang in langs){
        Console.WriteLine(lang.Prettify());
      }
    }
    public static void PrintAll(IEnumerable<Object> langs){
      foreach(var lang in langs){
        Console.WriteLine(lang);
      }
    }
  }

