using System;
using System.Collections.Generic;

class MorseCodeTranslator
{
    static Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>()
    {
        {'A', ".-"},
        {'B', "-..."},
        {'C', "-.-."},
        {'D', "-.."},
        {'E', "."},
        {'F', "..-."},
        {'G', "--."},
        {'H', "...."},
        {'I', ".."},
        {'J', ".---"},
        {'K', "-.-"},
        {'L', ".-.."},
        {'M', "--"},
        {'N', "-."},
        {'O', "---"},
        {'P', ".--."},
        {'Q', "--.-"},
        {'R', ".-."},
        {'S', "..."},
        {'T', "-"},
        {'U', "..-"},
        {'V', "...-"},
        {'W', ".--"},
        {'X', "-..-"},
        {'Y', "-.--"},
        {'Z', "--.."}
    };

    static string MorseToEnglish(string morseCode)
    {

      List<string> words = morseCode.Split(' ').ToList();

      string final = "";

      foreach(var word in words){
        
        if (word == "|"){
          final += " ";
        }

        foreach(var thing in morseCodeDictionary){

          if (thing.Value == word){
            final += thing.Key;
          }

        }
      }

      return final;

    }

    static void Main()
    {
        string morseCode = Console.ReadLine();
        string englishMessage = MorseToEnglish(morseCode.ToUpper());

        Console.WriteLine(englishMessage);
    }
}
