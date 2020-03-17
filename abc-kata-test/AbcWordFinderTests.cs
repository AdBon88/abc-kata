using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace abc_kata
{
    public class AbcWordFinderTests
    {        readonly List<Block> blocks = new BlockCollectionFixture().CreateBlocks();



        [Fact]
        public void CreateBlocks_blocks_OutputsTrue(){

            List<Block> actual = new AbcWordFinder().CreateBlocks();
            Assert.True(Enumerable.SequenceEqual(actual, blocks));
        }

        [Fact]
        public void FindWord_AA_OutputsTrue() {

            bool actual = new AbcWordFinder().FindWord(blocks, "AA");
            Assert.True(actual);
        }

        [Fact]
        public void FindWord_AAA_OutputsFalse() {

            bool actual = new AbcWordFinder().FindWord(blocks, "AAA");
            Assert.False(actual);
        }

        [Fact]
        public void FindWord_AAAA_OutputsFalse() {

            bool actual = new AbcWordFinder().FindWord(blocks, "AAAA");
            Assert.False(actual);
        }

        [Fact]
        public void FindWord_BA_OutputsTrue() {

            bool actual = new AbcWordFinder().FindWord(blocks, "BA");
            Assert.True(actual);
        }

        [Fact]
        public void FindWord_BAR_OutputsTrue() {

            bool actual = new AbcWordFinder().FindWord(blocks, "BAR");
            Assert.True(actual);
        }

        [Fact]
        public void FindWord_BARK_OutputsTrue() {

            bool actual = new AbcWordFinder().FindWord(blocks, "BARK");
            Assert.True(actual);
        }

        [Fact]
        public void FindWord_BOOK_OutputsFalse() {

            bool actual = new AbcWordFinder().FindWord(blocks, "BOOK");
            Assert.False(actual);
        }

        [Fact]
        public void FindWord_TREAT_OutputsTrue() {

            bool actual = new AbcWordFinder().FindWord(blocks, "TREAT");
            Assert.True(actual);
        }

        [Fact]
        public void FindWord_COMMON_OutputsFalse() {

            bool actual = new AbcWordFinder().FindWord(blocks, "COMMON");
            Assert.False(actual);
        }

        [Fact]
        public void FindWord_SQUAD_OutputsTrue() {

            bool actual = new AbcWordFinder().FindWord(blocks, "SQUAD");
            Assert.True(actual);
        }

        [Fact]
        public void FindWord_CONFUSE_OutputsTrue() {

            bool actual = new AbcWordFinder().FindWord(blocks, "CONFUSE");
            Assert.True(actual);
        }

    }
}
