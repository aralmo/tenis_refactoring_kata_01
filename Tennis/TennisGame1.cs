namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1Name)
                m_score1 += 1;
            else
                m_score2 += 1;
        }

        public string GetScore()
        {
            if (m_score1 == m_score2)
            {
                return m_score1 switch
                {
                    int score when score < 3 => $"{ScoreStringFor(score)}-All",
                    _ => "Deuce"
                };
            }

            if (m_score1 >= 4 || m_score2 >= 4)
            {
                var minusResult = m_score1 - m_score2;
                if (minusResult == 1) return $"Advantage {player1Name}";
                if (minusResult == -1) return $"Advantage {player2Name}";
                if (minusResult >= 2) return $"Win for {player1Name}";
                return $"Win for {player2Name}";
            }

            return $"{ScoreStringFor(m_score1)}-{ScoreStringFor(m_score2)}";
        }

        private static string ScoreStringFor(int score)
        {
            return score switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                3 => "Forty"
            };
        }
    }
}