using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsTournament
{
    public class ComputeScore
    {
        public static void ComputeFinalScore(IEnumerable<string[]> strategy) 
        {
            int opponent_choice_score = 0;
            int player_choice_score = 0;
            int opponent_result_score = 0;
            int player_result_score = 0;
            foreach (string[] strategyItem in strategy)
            {
                Console.Write(strategyItem[0]);
                Console.Write(" ");
                Console.WriteLine(strategyItem[1]);
                if (string.Equals(strategyItem[0], "A"))
                {
                    opponent_choice_score = 1;
                }
                if (string.Equals(strategyItem[0], "B"))
                {
                    opponent_choice_score = 2;
                }
                if (string.Equals(strategyItem[0], "C"))
                {
                    opponent_choice_score = 3;
                }

                if (string.Equals(strategyItem[1], "X"))
                {
                    player_choice_score = 1;
                }
                if (string.Equals(strategyItem[1], "Y"))
                {
                    player_choice_score = 2;
                }
                if (string.Equals(strategyItem[1], "Z"))
                {
                    player_choice_score = 3;
                }

                // Opponent Chose Rock

                if (string.Equals(strategyItem[0], "A"))
                {
                    if (string.Equals(strategyItem[1], "X"))
                    {
                        opponent_result_score = opponent_choice_score + 3;
                        player_result_score = player_result_score + 1 + 3;
                    }
                }
                if (string.Equals(strategyItem[0], "A"))
                {
                    if (string.Equals(strategyItem[1], "Y"))
                    {
                        opponent_result_score = opponent_choice_score + 0;
                        player_result_score = player_result_score + 2 + 6;
                    }
                }
                if (string.Equals(strategyItem[0], "A"))
                {
                    if (string.Equals(strategyItem[1], "Z"))
                    {
                        opponent_result_score = opponent_choice_score + 6;
                        player_result_score = player_result_score + 3 + 0;
                    }
                }

                // Opponent Chose Paper

                if (string.Equals(strategyItem[0], "B"))
                {
                    if (string.Equals(strategyItem[1], "X"))
                    {
                        opponent_result_score = opponent_choice_score + 6;
                        player_result_score = player_result_score + 1 + 0;
                    }
                }
                if (string.Equals(strategyItem[0], "B"))
                {
                    if (string.Equals(strategyItem[1], "Y"))
                    {
                        opponent_result_score = opponent_choice_score + 3;
                        player_result_score = player_result_score + 2 + 3;
                    }
                }
                if (string.Equals(strategyItem[0], "B"))
                {
                    if (string.Equals(strategyItem[1], "Z"))
                    {
                        opponent_result_score = opponent_choice_score + 0;
                        player_result_score = player_result_score + 3 + 6;
                    }
                }

                // Opponent Chose Scissors

                if (string.Equals(strategyItem[0], "C"))
                {
                    if (string.Equals(strategyItem[1], "X"))
                    {
                        opponent_result_score = opponent_choice_score + 0;
                        player_result_score = player_result_score + 1 + 6;
                    }
                }
                if (string.Equals(strategyItem[0], "C"))
                {
                    if (string.Equals(strategyItem[1], "Y"))
                    {
                        opponent_result_score = opponent_choice_score + 6;
                        player_result_score = player_result_score + 2 + 0;
                    }
                }
                if (string.Equals(strategyItem[0], "C"))
                {
                    if (string.Equals(strategyItem[1], "Z"))
                    {
                        opponent_result_score = opponent_choice_score + 3;
                        player_result_score = player_result_score + 3 + 3;
                    }
                }
                Console.WriteLine(player_result_score);
            }
            Console.WriteLine(player_result_score);
        }
    }
}
