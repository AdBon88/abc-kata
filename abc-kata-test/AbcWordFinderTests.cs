using System;
using System.Collections.Generic;
using Xunit;

namespace abc_kata
{
    public class AbcWordFinderTests
    {        readonly List<Block> blocks = new AbcWordFinder().CreateBlocks();

        [Fact]
        public void FindWord_A_OutputsTrue(){

            bool actual = new AbcWordFinder().FindWord(blocks, "A");
            Assert.True(actual);
        }

        [Fact]
        public void FindWord_Bark_OutputsTrue() {

            bool actual = new AbcWordFinder().FindWord(blocks, "Bark");
            Assert.True(actual);
        }
    }
}
