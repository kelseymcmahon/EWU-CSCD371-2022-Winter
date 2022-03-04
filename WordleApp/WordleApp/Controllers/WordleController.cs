﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WordleApp.Controllers
{
    [Route("api/wordle")]
    [ApiController]
    public class WordleController : ControllerBase
    {
        private List<string>? _Words;

        public List<string> Words
        {
            get
            {
                if (_Words is null)
                {
                    _Words = System.IO.File.ReadAllLines("Words.txt").ToList();
                }
                return _Words;
            }
        }

        // Route = /api/wordle/WordCount
        [HttpGet("WordCount")]
        public int GetWordCount()
        {
            return Words.Count;
        }

        [HttpPost("guess")]
        public List<Letter> Guess([FromBody] Guess guess)
        {
            var word = Words[guess.WordIndex];

            List<Letter> result = CheckGuess(guess.MyGuess!.ToLower(), word.ToLower());

            return result;
        }

        public static List<Letter> CheckGuess(string guess, string word)
        {
            List<Letter> result = new();

            int index = 0;
            foreach (char c in guess)
            {
                Letter letter;
                if (word.Contains(c))
                {
                    if (word[index] == guess[index])
                    {
                        letter = new Letter { Character = c, State = Validness.RightLetterRightPlace };
                    }
                    else
                    {
                        letter = new Letter { Character = c, State = Validness.RightLetteWrongPlace };
                    }
                }
                else
                {
                    letter = new Letter { Character = c, State = Validness.WrongLetter };
                }
                result.Add(letter);
                index++;
            }

            return result;
        }
    }

    public class Letter
    {
        public char Character { get; set; }
        public Validness State { get; set; }
    }

    public class Guess
    {
        public string? MyGuess { get; set; }
        public int WordIndex { get; set; }
    }

    public enum Validness
    {
        WrongLetter = 0,
        RightLetteWrongPlace = 1,
        RightLetterRightPlace = 2
    }

}
