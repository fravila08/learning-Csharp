using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;
    public Profile(
      string name,
      int age, 
      string city,
      string country, 
      string pronouns= "they/them")
    {
     this.name = name;
     this.age= age;
     this.city = city;
     this.country =  country;
     this.pronouns = pronouns;
     this.hobbies = new string[0];
    }

    // MEHTODS
    public string ViewProfile()
    {
      string myProfile= $"My name is {name}, I am {age} years old and live in {city} {country}. My pronouns are {pronouns}. My Hobbies are: \n";
      foreach (string hobby in hobbies)
      {
        myProfile += $"-- {hobby} \n";
      }
      return myProfile;
    }

    // GETTERS AND SETTERS
    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}