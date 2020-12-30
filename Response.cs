using System;
using System.Xml.Serialization;

  class Response {
    public static void ChatThink(string userChat)
    {
      string m = userChat;
            string ChatUI = @"
      --------------------------------------------
      Welcome to April! A Smart C# Chat bot!
      April runs on a library responding to mostly
      anything in enlish slang!
      --------------------------------------------

      ";
      
      if (m == "Hello!" || m == "hello" || m == "hi" || m == "Hi!" || m == "HI!" || m.Contains("how are you") == true || m.Contains("whats up") == true)
      {
        Console.Clear();
        Console.WriteLine(ChatUI);
        Console.WriteLine("Hi! Im April, How are you doing?");
        Console.ReadKey();
        Bot.Chat();
      }
      else if (m == "im doing good" || m == "Im doing good" || m == "Im alright" || m == "im alright" || m == "im good" || m == "Im good" || m.Contains("im doing good") == true || m.Contains("im good!") == true)
      {
        Console.Clear();
        Console.WriteLine(ChatUI);
        Console.WriteLine("Thats great to hear! Im doing well too!");
        Console.ReadKey();
        Bot.Chat();
      }
      else
      {
        Console.Clear();
        Console.WriteLine(ChatUI);
        Console.WriteLine("Im sorry, i dont understand :(");
        Console.ReadKey();
        Bot.Chat();
      }

    }
  }