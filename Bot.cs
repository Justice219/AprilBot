using System;
using System.Xml.Serialization;

  class Bot {
    public static void Chat()
    {

      string message;
      string ChatUI = @"
      --------------------------------------------
      Welcome to April! A Smart C# Chat bot!
      April runs on a library responding to mostly
      anything in enlish slang!
      --------------------------------------------

      ";

      Console.Clear();
      Console.WriteLine(ChatUI);
      Console.WriteLine("Enter a message!");
      message = Console.ReadLine().ToLower();

      Response.ChatThink(message);

    }
  }