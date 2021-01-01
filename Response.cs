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
      
      if (m == "hello!" || m == "hello" || m == "hi" || m == "Hi!" || m == "HI!" || m.Contains("how are you") == true || m.Contains("whats up") == true)
      {
        Console.Clear();
        Console.WriteLine(ChatUI);
        Console.WriteLine("Hi! Im April, How are you doing?");
        Console.ReadKey();
        Bot.Chat();
      }
      else if (m == "im doing good" || m == "Im doing good" || m == "Im alright" || m == "im alright" || m == "im good" || m == "Im good" || m.Contains("im doing good") == true || m.Contains("im good!") == true)
      {

        string[] Two = { "Thas great to hear! Im doing well too!", "Im doing good aswell!", "Im glad your doing well!"
        };
        Random rand = new Random();
        int index = rand.Next(Two.Length);

        Console.Clear();
        Console.WriteLine(ChatUI);
        Console.WriteLine(Two[index]);
        Console.ReadKey();
        Bot.Chat();
      }
      else if (m == "thats cap!" || m == "thats cap" || m == "your capping" || m == "cap" || m == "cap!" ||m.Contains("your capping") == true || m.Contains("stop cappping!") == true )
      {
        string[] Three = { "Im not capping :( ", "How dare you not belive me!", "Thats not cap at all!", "Whats wrong with yourself to doubt me!", "Hey! Im not lying!"
        };
        Random rand = new Random();
        int index = rand.Next(Three.Length);

        Console.Clear();
        Console.WriteLine(ChatUI);
        Console.WriteLine(Three[index]);
        Console.ReadKey();
        Bot.Chat();
      }
      else if (m == "are you a robot?" || m == "are you a robot" || m == "are you a ai" || m == "are you an ai" || m == "are you a bad robot" ||m.Contains("are you a robot") == true || m.Contains("are you a ai") == true || m.Contains("are you an ai") )
      {
        string[] Four = { "Yes im an AI!", "No im C3PO :DDD", "No im darth vader!", "No im R2D@", "Im a awesome robot AI"
        };
        Random rand = new Random();
        int index = rand.Next(Four.Length);

        Console.Clear();
        Console.WriteLine(ChatUI);
        Console.WriteLine(Four[index]);
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