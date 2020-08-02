using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {

    // Update the players position using X & Y Coordinates
    public new static void UpdatePosition(string key, out int xChange, out int yChange) {
      // Assign values initially to avoid an error later.
      xChange = 0;
      yChange = 0;

      switch(key)
      {
        case "DownArrow":
          yChange += 1;
          break;
        case "UpArrow":
          yChange -= 1;
          break;
        case "RightArrow":
          xChange += 1;
          break;
        case "LeftArrow":
          xChange += 1;
          break;
      }
    }

    // Update the cursor for the player to have some visual feedback.

    public new static char UpdateCursor(string key)
    {
      char direction = '<';
      switch(key)
      {
        case "DownArrow":
          direction = 'v';
          break;
        case "UpArrow":
          direction = '^';
          break;
        case "LeftArrow":
          direction = '<';
          break;
        case "RightArrow":
          direction = '>';
          break;
      }

      return direction;
    }

    // If we don't have this method, hitting the boundaries will break the game!!!!

    public new static int KeepInBounds(int xCoord, int maximum)
    {
      if(xCoord >= maximum)
      {
        return 0; // sending the player to the other side of the screen.
      } else if(xCoord <= 0)
      {
        return maximum; // same thing
      } else
      {
        return xCoord; // okay
      }
    }


    public new static bool DidScore(int characterX, int characterY, int fruitX, int fruitY)
    {
      if(characterX == fruitX && characterY == fruitY)
      {
        return true;
      } else 
      {
        return false;
      }
    }
  }
} 