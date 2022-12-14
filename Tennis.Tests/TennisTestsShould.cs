using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tennis.Tests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] { 0, 0, "Love-All" },
            new object[] { 1, 1, "Fifteen-All" },
            new object[] { 2, 2, "Thirty-All" },
            new object[] { 3, 3, "Deuce" },
            new object[] { 4, 4, "Deuce" },
            new object[] { 1, 0, "Fifteen-Love" },
            new object[] { 0, 1, "Love-Fifteen" },
            new object[] { 2, 0, "Thirty-Love" },
            new object[] { 0, 2, "Love-Thirty" },
            new object[] { 3, 0, "Forty-Love" },
            new object[] { 0, 3, "Love-Forty" },
            new object[] { 4, 0, "Win for player1" },
            new object[] { 0, 4, "Win for player2" },
            new object[] { 2, 1, "Thirty-Fifteen" },
            new object[] { 1, 2, "Fifteen-Thirty" },
            new object[] { 3, 1, "Forty-Fifteen" },
            new object[] { 1, 3, "Fifteen-Forty" },
            new object[] { 4, 1, "Win for player1" },
            new object[] { 1, 4, "Win for player2" },
            new object[] { 3, 2, "Forty-Thirty" },
            new object[] { 2, 3, "Thirty-Forty" },
            new object[] { 4, 2, "Win for player1" },
            new object[] { 2, 4, "Win for player2" },
            new object[] { 4, 3, "Advantage player1" },
            new object[] { 3, 4, "Advantage player2" },
            new object[] { 5, 4, "Advantage player1" },
            new object[] { 4, 5, "Advantage player2" },
            new object[] { 15, 14, "Advantage player1" },
            new object[] { 14, 15, "Advantage player2" },
            new object[] { 6, 4, "Win for player1" },
            new object[] { 4, 6, "Win for player2" },
            new object[] { 16, 14, "Win for player1" },
            new object[] { 14, 16, "Win for player2" },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class TennisTestsShould
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis1Test(int p1, int p2, string expected)
        {
            var game = new TennisGame1("player1", "player2");
            CheckAllScores(game, p1, p2, expected);
        }

        [Theory]
        [InlineData(0, "Love")]
        [InlineData(1, "Fifteen")]
        [InlineData(2, "Thirty")]
        public void ReturnScoreAllWhenBothPlayersAreEqualAndNotOverThirty(int points, string scoreString)
        {
            string p1Name = Guid.NewGuid().ToString();
            string p2Name = Guid.NewGuid().ToString();

            var game = new TennisGame1(p1Name, p2Name);

            AddGamePoints(game, p1Name, points);
            AddGamePoints(game, p2Name, points);

            Assert.Equal($"{scoreString}-All", game.GetScore());
        }

        [Fact]
        public void ReturnDeuceWhenBothPlayersEqualAndOverThirty()
        {
            string p1Name = Guid.NewGuid().ToString();
            string p2Name = Guid.NewGuid().ToString();

            var game = new TennisGame1(p1Name, p2Name);

            AddGamePoints(game, p1Name, 3);
            AddGamePoints(game, p2Name, 3);

            for (int i = 0; i < 10; i++)
            {
                game.WonPoint(p1Name);
                game.WonPoint(p2Name);
                Assert.Equal("Deuce", game.GetScore());
            }
        }

        [Fact]
        public void ReturnWinWhenPlayerTwoPointsAheadAndOverThirty()
        {
            string p1Name = Guid.NewGuid().ToString();
            string p2Name = Guid.NewGuid().ToString();

            //player 1 wins
            var game = new TennisGame1(p1Name, p2Name);
            AddGamePoints(game, p1Name, 4);
            Assert.Equal($"Win for {p1Name}", game.GetScore());

            //player 2 wins
            game = new TennisGame1(p1Name, p2Name);
            AddGamePoints(game, p2Name, 4);
            Assert.Equal($"Win for {p2Name}", game.GetScore());
        }

        [Fact]
        public void ReturnAdvantageWhenPlayerOnePointAheadAndOverThirty()
        {
            string p1Name = Guid.NewGuid().ToString();
            string p2Name = Guid.NewGuid().ToString();

            //player 1 wins
            var game = new TennisGame1(p1Name, p2Name);
            AddGamePoints(game, p1Name, 4);
            AddGamePoints(game, p2Name, 3);
            Assert.Equal($"Advantage {p1Name}", game.GetScore());

            //player 2 wins
            game = new TennisGame1(p1Name, p2Name);
            AddGamePoints(game, p2Name, 4);
            AddGamePoints(game, p1Name, 3);
            Assert.Equal($"Advantage {p2Name}", game.GetScore());
        }

        private static void AddGamePoints(ITennisGame game, string player, int points)
        {
            for (int i = 0; i < points; i++)
                game.WonPoint(player);
        }


        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis2Test(int p1, int p2, string expected)
        {
            var game = new TennisGame2("player1", "player2");
            CheckAllScores(game, p1, p2, expected);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis3Test(int p1, int p2, string expected)
        {
            var game = new TennisGame3("player1", "player2");
            CheckAllScores(game, p1, p2, expected);
        }

        private void CheckAllScores(ITennisGame game, int player1Score, int player2Score, string expectedScore)
        {
            var highestScore = Math.Max(player1Score, player2Score);
            for (var i = 0; i < highestScore; i++)
            {
                if (i < player1Score)
                    game.WonPoint("player1");
                if (i < player2Score)
                    game.WonPoint("player2");
            }

            Assert.Equal(expectedScore, game.GetScore());
        }
    }
}