// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program Stories
      Author: Francisco
      */


      // Let the user know that the program is starting:
      Console.WriteLine("The program has began!");

      // Give the Mad Lib a title:
      string title = "The wake up Call";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Enter a name:");
      string name = Console.ReadLine();
      Console.WriteLine("Now we need 3 Adjectives");
      Console.WriteLine("Write your first as a feeling:");
      string feeling = Console.ReadLine();
      Console.WriteLine("Write your second as a kind of day:");
      string kindOfDay = Console.ReadLine();
      Console.WriteLine("Write a group of what?");
      string grouping = Console.ReadLine();
      Console.WriteLine("What to keep in stores?");
      string keepInStores = Console.ReadLine();
      Console.WriteLine("How did they protest?");
      string protest = Console.ReadLine();
      Console.WriteLine("Write your third adjective as a reaction: ");
      string reaction = Console.ReadLine();
      Console.WriteLine("Who would he call?");
      string caller = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {kindOfDay} day!' Outside, a bunch of {grouping}s were protesting to keep {keepInStores} in stores. They began to {protest} to the rhythm of the beat, which made all the {grouping}s very {reaction}. Concerned, {name} texted {caller}, who flew to {name} and dropped in a puddle of frozen water. {name} woke up in the year 2022, in a world where {grouping}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}