﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Packman_Challenge
{
    public class PackManRepository
    {
        private List<string> GameMoves;

        Dictionary<string, int> MoveScore = new Dictionary<string, int>()
        {
            { "Cherry", 100 },
            { "Strawberry" , 300 },
            { "Orange", 500 },
            { "Apple", 700 },
            { "Melon", 1000 },
            { "Galaxian", 2000 },
            { "Bell", 3000 },
            { "Key", 5000 },
            { "Dot", 10 },
            { "VulnerableGhost", 200 }
        };
        private int packManTotal = 5000;
        private int packManLives = 3;
        //private int ghostCount = 1;
        private int ghostCount = 0;
        private bool ExtraLife = true;
        private int ghostBonus = 1;
        public void GetInput(string filePath)
        {
            var text = System.IO.File.ReadAllText(filePath);
            GameMoves = text.Split(',').ToList();
        }
        public void PlayGame()
        {

            foreach (string move in GameMoves)
            {
                if (packManLives < 1)
                    break;


                switch (move)
                {
                    case "VulnerableGhost":
                        {
                            var newPoints = Convert.ToInt32(200 * Math.Pow(2, ghostCount++));
                            //packManTotal += (MoveScore[move] * ghostBonus);
                            //ghostBonus = ghostCount * 2;
                            packManTotal += newPoints;
                            //ghostCount++;
                            break;
                        }
                    case "InvincibleGhost":
                        {
                            packManLives--;
                            break;
                        }
                    default:
                        {
                            packManTotal += (MoveScore[move]);
                            break;
                        }
                }

                if (packManTotal >= 10000 && ExtraLife)
                {

                    ExtraLife = false;
                    ++packManLives;
                }

            }

            Console.WriteLine("Game Over, Final Score:{0}", packManTotal);
            Console.ReadKey();

        }
    }


}
