using System;

namespace rockcsharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Random mathRandom = new Random();
      string title = @"
 _______  _______  _______  _          
(  ____ )(  ___  )(  ____ \| \    /\   
| (    )|| (   ) || (    \/|  \  / /   
| (____)|| |   | || |      |  (_/ /    
|     __)| |   | || |      |   _ (     
| (\ (   | |   | || |      |  ( \ \    
| ) \ \__| (___) || (____/\|  /  \ \ _ 
|/   \__/(_______)(_______/|_/    \/( )
                                    |/ 
 _______  _______  _______  _______  _______    
(  ____ )(  ___  )(  ____ )(  ____ \(  ____ )   
| (    )|| (   ) || (    )|| (    \/| (    )|   
| (____)|| (___) || (____)|| (__    | (____)|   
|  _____)|  ___  ||  _____)|  __)   |     __)   
| (      | (   ) || (      | (      | (\ (      
| )      | )   ( || )      | (____/\| ) \ \__ _ 
|/       |/     \||/       (_______/|/   \__/( )
                                             |/ 
 _______  _______ _________ _______  _______  _______  _______  _______ 
(  ____ \(  ____ \\__   __/(  ____ \(  ____ \(  ___  )(  ____ )(  ____ \
| (    \/| (    \/   ) (   | (    \/| (    \/| (   ) || (    )|| (    \/
| (_____ | |         | |   | (_____ | (_____ | |   | || (____)|| (_____ 
(_____  )| |         | |   (_____  )(_____  )| |   | ||     __)(_____  )
      ) || |         | |         ) |      ) || |   | || (\ (         ) |
/\____) || (____/\___) (___/\____) |/\____) || (___) || ) \ \__/\____) |
\_______)(_______/\_______/\_______)\_______)(_______)|/   \__/\_______)";
      Console.WriteLine(title);
      Console.WriteLine("What is your Name?");
      bool playing = true;
      string name = Console.ReadLine();
      Console.WriteLine("Hello " + name + ", would you like to play Rock, Paper, Scissors?");
      string response = Console.ReadLine().ToLower();
      if (response == "yes")
      {
        while (playing)
        {


          Console.Clear();
          Console.WriteLine("Prepare to be Destroyed!");
          Console.WriteLine("Choose: Rock, Paper, or Scissors");
          string playerChoice = Console.ReadLine().ToLower();
          int compChoice = mathRandom.Next(3);

          if (compChoice == 0)
          {

            Console.WriteLine("Computer Chooses: " + compChoice.ToString("Rock"));
            if (playerChoice == "paper")
            {
              Console.Write("YOU WIN!");
            }
            else if (playerChoice == "rock")
            {
              System.Console.WriteLine("You tied, ties are like kissing your sister");
            }
            else Console.Write("YOU HAVE BEEN DESTROYED, YOU LOSE!");
          }
          else if (compChoice == 1)
          {

            Console.WriteLine("Computer Chooses: " + compChoice.ToString("Paper"));
            if (playerChoice == "scissors")
            {
              Console.Write("YOU WIN!");
            }
            else if (playerChoice == "paper")
            {
              System.Console.WriteLine("You tied, ties are like kissing your sister");
            }
            else System.Console.WriteLine("YOU HAVE BEEN DESTROYED, YOU LOSE!");
          }
          else
          {

            Console.WriteLine("Computer Chooses: " + compChoice.ToString("Scissors"));
            if (playerChoice == "rock")
            {
              Console.Write("YOU WIN!");
            }
            else if (playerChoice == "scissors")
            {
              System.Console.WriteLine("You tied, ties are like kissing your sister");
            }
            else System.Console.WriteLine("YOU HAVE BEEN DESTROYED, YOU LOSE!");
          }
          System.Console.WriteLine("Would You Like To Play Again?");
          string answer = Console.ReadLine().ToLower();
          if (answer == "no")
          {
            return;
          }

        }
      }
      else return;
    }
  }
}
