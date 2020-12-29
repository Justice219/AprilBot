using System;

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
    Console.ReadLine();

  }
}