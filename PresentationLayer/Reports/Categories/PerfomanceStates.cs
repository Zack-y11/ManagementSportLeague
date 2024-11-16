using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Reports.Categories
{
  
        public class PerfomanceStats
        {
            public string TeamName { get; set; }
            public int Played { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Draws { get; set; }
            public int GoalsFor { get; set; }
            public int GoalsAgainst { get; set; }
            public int Points { get; set; }

            // Default constructor
            public PerfomanceStats()
            {
                TeamName = "";
                Played = 0;
                Wins = 0;
                Losses = 0;
                Draws = 0;
                GoalsFor = 0;
                GoalsAgainst = 0;
                Points = 0;
            }

            // Constructor with parameters
            public PerfomanceStats(string teamName, int played, int wins, int losses, int draws,
                int goalsFor, int goalsAgainst, int points)
            {
                TeamName = teamName;
                Played = played;
                Wins = wins;
                Losses = losses;
                Draws = draws;
                GoalsFor = goalsFor;
                GoalsAgainst = goalsAgainst;
                Points = points;
            }

            // Optional: Method to calculate points based on wins/draws
            public void CalculatePoints()
            {
                // Assuming 3 points for win, 1 for draw
                Points = (Wins * 3) + Draws;
            }

            // Optional: Method to validate data
            public bool IsValid()
            {
                // Check if team name is not empty
                if (string.IsNullOrEmpty(TeamName))
                    return false;

                // Check if played matches equals sum of wins, losses and draws
                if (Played != (Wins + Losses + Draws))
                    return false;

                // Add any other validation rules you need

                return true;
            }
        }
    }


