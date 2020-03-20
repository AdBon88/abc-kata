using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace abc_kata
{
    public class AbcWordFinderTests
    {        readonly List<Block> blocks = new BlockCollectionFixture().CreateBlocks();

        [Fact]
        public void CreateBlocks_CollectionCountMatchesFixtureCount_OutputsTrue(){

            List<Block> actual = new AbcWordFinder().CreateBlocks();
            Assert.True(actual.Count == blocks.Count());
        }

        [Fact]
        public void GetUserInput_allowsAlphaCharsOrForwardSlash() {

            string actual = new AbcWordFinder().GetUserInput();
            Assert.True(actual.Count == blocks.Count());
        }

        [Fact]
        public void WordFound_AA_OutputsTrue() {

            bool actual = new AbcWordFinder().WordFound("AA", blocks);
            Assert.True(actual);
        }

        [Fact]
        public void WordFound_AAA_OutputsFalse() {

            bool actual = new AbcWordFinder().WordFound("AAA", blocks);
            Assert.False(actual);
        }

        [Fact]
        public void WordFound_AAAA_OutputsFalse() {

            bool actual = new AbcWordFinder().WordFound("AAAA", blocks);
            Assert.False(actual);
        }

        [Fact]
        public void WordFound_BA_OutputsTrue() {

            bool actual = new AbcWordFinder().WordFound("BA", blocks);
            Assert.True(actual);
        }

        [Fact]
        public void WordFound_BAR_OutputsTrue() {

            bool actual = new AbcWordFinder().WordFound("BAR", blocks);
            Assert.True(actual);
        }

        [Fact]
        public void WordFound_BARK_OutputsTrue() {

            bool actual = new AbcWordFinder().WordFound("BARK", blocks);
            Assert.True(actual);
        }

        [Fact]
        public void WordFound_BOOK_OutputsFalse() {

            bool actual = new AbcWordFinder().WordFound("BOOK", blocks);
            Assert.False(actual);
        }

        [Fact]
        public void WordFound_TREAT_OutputsTrue() {

            bool actual = new AbcWordFinder().WordFound("TREAT", blocks);
            Assert.True(actual);
        }

        [Fact]
        public void WordFound_COMMON_OutputsFalse() {

            bool actual = new AbcWordFinder().WordFound("COMMON", blocks);
            Assert.False(actual);
        }

        [Fact]
        public void WordFound_SQUAD_OutputsTrue() {

            bool actual = new AbcWordFinder().WordFound("SQUAD", blocks);
            Assert.True(actual);
        }

        [Fact]
        public void WordFound_CONFUSE_OutputsTrue() {

            bool actual = new AbcWordFinder().WordFound("CONFUSE", blocks);
            Assert.True(actual);
        }

    }
}
