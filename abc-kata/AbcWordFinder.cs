using System;
using System.Collections.Generic;

namespace abc_kata {
    public class AbcWordFinder {

        

        public void Run() {
            List<Block> blocks = new List<Block>();
            blocks = CreateBlocks();
            FindWord(blocks, "A");
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

        public bool FindWord(List<Block> blocks, String word) {
            
            foreach (Block block in blocks) {
                if(block.Side1 == word[0]) {
                    return true;
                }
            }
            return false;
        }
    }
}
