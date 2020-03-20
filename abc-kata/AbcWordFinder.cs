using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace abc_kata {
    public class AbcWordFinder {


        public void Run() {
            List<Block> blocks = CreateBlocks();

            Regex userInput Regex = GetUserInput(Regex(@"[A-Za-z/]")
            string userInput = GetUserInput(new Regex(@"[A-Za-z/]");

            while (userInput != "/Q") {
                Console.WriteLine($"\nCan_make_word(\"{userInput}\")");
                Console.WriteLine($"{WordFound(userInput, blocks)}\n");
                userInput = GetUserInput();
            }

            Environment.Exit(0);
        }

        public List<Block> CreateBlocks() {

            List<Block> blocks = new List<Block>() {
                new Block('B','O'),
                new Block('X','K'),
                new Block('D','Q'),
                new Block('C','P'),
                new Block('N','A'),
                new Block('G','T'),
                new Block('R','E'),
                new Block('T','G'),
                new Block('Q','D'),
                new Block('F','S'),
                new Block('J','W'),
                new Block('H','U'),
                new Block('V','I'),
                new Block('A','N'),
                new Block('O','B'),
                new Block('E','R'),
                new Block('S','F'),
                new Block('L','Y'),
                new Block('P','C'),
                new Block('Z','M'),
            };

            return blocks;
        }

        public string GetUserInput(Regex validInputRegex) {
            Console.WriteLine("Enter a word to search for, or /Q to quit:");

            

            string userInput = "";
            bool validInput = false;

            while (!validInput) {
                userInput = Console.ReadLine().ToUpper();
                validInput = IsInputValid(userInput, validInputRegex);
                if (!validInput)
                    Console.WriteLine("Please enter alphabetic characters only, or /Q to quit");
            }

            return userInput;
        }

        public bool IsInputValid(string userInput, Regex validInputRegex) {

            Match regexMatch;
            regexMatch = validInputRegex.Match(userInput);
            return regexMatch.Success;
        }

        public bool WordFound(string word, List<Block> blocks) {

            foreach (char letter in word) {
                if (!LetterFoundInBlockCollection(letter, blocks))
                    return false;
            }
            return true;
        }

        private bool LetterFoundInBlockCollection(char currentLetter, List<Block> blocks) {

            foreach (Block block in blocks) {
                if (block.Side1 == currentLetter || block.Side2 == currentLetter) {
                    blocks.Remove(block);
                    return true;
                }
            }
            return false;
        }
        
    }

}
