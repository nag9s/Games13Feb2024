namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            var sut = new PlayerCharacter();
            Assert.True( sut.IsNoob);
        }

        [Fact]
        public void CalculateFullName()
        {
            var sut = new PlayerCharacter();
            sut.FirstName = "11feb";
            sut.LastName = "2024";
            Assert.Equal("11feb 2024",sut.FullName);
        }
    }
}