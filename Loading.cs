using System;
using System.Xml.Serialization;

  class Loading {
    public static void LoadingScreen()
    {
      string LoadingText = @"
             _            _ _         __   _  __  
            /_\  _ __ _ _(_) |  __ __/  \ / |/  \ 
           / _ \| '_ \ '_| | |  \ V / () || | () |
          /_/ \_\ .__/_| |_|_|   \_/ \__(_)_|\__/ 
                |_|                              
      ";
      Console.Clear();
      Console.WriteLine(LoadingText);
      Console.WriteLine("A Simple C# Chatbot");
      Console.WriteLine("");
      Console.WriteLine("Please note that this bot will not be");
      Console.WriteLine("able to understand everything so keep");
      Console.WriteLine("it simple!");
      Console.WriteLine("");
      Console.WriteLine("Press any key to begin!");
      Console.ReadLine();


      Bot.Chat();

    }
  }