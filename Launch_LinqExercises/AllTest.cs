namespace Launch_LinqExercises
{
    public class AllTest
    {
        [Fact]
        public void AllZeros()
        {
            var numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
            var allZeros = numbers.All(n => n == 0);
            Assert.True(allZeros);
        }

        [Fact]
        public void NotAllZeros()
        {
            var numbers = new List<int> { 0, 0, 0, 0, 1, 0, 0 };
            var allZeros = numbers.All(n =>
                    n == 0 // replace with your code .. can collapse into one line above
            );
            Assert.False(allZeros);
        }

        [Fact]
        public void AllGone()
        {
            var words = new List<string> { "gone", "gone", "gone", "gone", "gone", "gone", "gone" };
            var allGone = words.All(w => w == "gone"); // replace with your code;
            Assert.True(allGone);
        }

        [Fact]
        public void NotAllGone()
        {
            var words = new List<string> { "gone", "gone", "gone", "gone", "there", "gone", "gone" };
            var allGone = words.All(w => w == "gone"); // replace with your code;
            Assert.False(allGone);
        }

        [Fact]
        public void AllEmpty()
        {
            var strings = new List<string> { "", "", "", "", "", "", "" };
            var allEmpty = strings.All(string.IsNullOrEmpty); // replace with your code;
            //var allEmpty = strings.All(string.IsNullOrEmpty); // This was the original way that I did it, but I wanted a "better" way. 
            Assert.True(allEmpty);
        }

        [Fact]
        public void NotAllEmpty()
        {
            var strings = new List<string> { "", "", "", "Full", "", "", "" };
            var allEmpty = strings.All(string.IsNullOrEmpty); // replace with your code;
            Assert.False(allEmpty);
        }

        [Fact]
        public void NotAllUppercase()
        {
            var words = new List<string> { "DOUGHNUT", "CASH", "MAIN", "bOWl", "SMACK", "SAND" };
            var allCaps = words.All(w => w == w.ToUpper()); // replace with your code;
            Assert.False(allCaps);
        }

        [Fact]
        public void AllLies()
        {
            var lies = new List<bool> { false, false, false, false };
            var allLies = lies.All(lie => lie == false); // replace with your code;
            Assert.True(allLies);
        }

        [Fact]
        public void AllMultiplesOf7()
        {
            var numbers = new List<int> { 42, 14, 35, 49, 28, 56, 21, 7 };
            var allMultiplesOf7 = numbers.All(num => num % 7 == 0); // replace with your code;
            Assert.True(allMultiplesOf7);
        }

        [Fact]
        public void NotAll3DigitsLong()
        {
            var numbers = new List<int> { 981, 831, 509, 332, 892, 8999, 110 };
            var all3Digits = numbers.All(num => num.ToString().Length == 3); // replace with your code;
            Assert.False(all3Digits);
        }

        [Fact]
        public void All4LetterWords()
        {
            var words = new List<string> { "love", "hate", "fire", "bird", "call" };
            var all4Letters = words.All(word => word.Length == 4); // replace with your code;
            Assert.True(all4Letters);
        }
    }
}