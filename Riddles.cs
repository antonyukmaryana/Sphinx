using System;
using System.Collections.Generic;
class Sphinx
{
  public static int lifeLine = 5;
  public static Dictionary <int, string> Riddles =new Dictionary<int,string>() {{1,"What has a head and a tail, but no body?"},{2,"What has an eye but can not see?"},
  {3,"What can travel around the world while staying in a corner?"},{4,"I'm tall when I'm young and I'm short when I'm old. What am I?"},{5,"What has hands but can not clap?"}};

  public static Dictionary<int, string> Answer = new Dictionary<int,string>() {{1,"coin"},{2,"needle"},{3,"stamp"},{4,"candle"},{5,"clock"}};

  static void Main()
  {

    Console.WriteLine("Do you want to play (enter 'Y' for Yes and 'N' for No)");
    string play = Console.ReadLine();
    if(play=="y" || play=="Y")
    { Console.WriteLine ("Game is starting, you have only 5 lives!");
      GenerateRiddles();
      Main();
    }
  }

  static void GenerateRiddles()
  {
    int num = RandomNumber();


    Console.WriteLine("Here is your Riddle ");
    Console.WriteLine(Riddles[num]);
    Console.WriteLine("Enter your Answer: ");
    string userAns= Console.ReadLine();
    if (userAns == Answer[num]){
      Console.WriteLine("Great you are in next level");
    }else {
      lifeLine=lifeLine-1;
      if (lifeLine!=0){
        Console.WriteLine("oops your current life Line is: " + lifeLine + " kindly try again");
        GenerateRiddles();
      }
      else { Console.WriteLine ("You are dead!");
      Main();
    }
  }
}

static int RandomNumber ()
{
  Random random = new Random();
  int index= random.Next(1,5);
  return index;
}



}
