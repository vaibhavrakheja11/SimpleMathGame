using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DropIceCream
{
    public class LevelManager : MonoBehaviour
    {
        public int currentLevel = 1;

        public Difficulty currentDifficulty = Difficulty.Easy;

        public static event Action<int,int> handleHUDUpdate;



        void Start()
        {
            SkillPointManager.handleSkillPointIncrease += CheckForLevelIncrease;
        }

        void CheckForLevelIncrease(int currentSkillPoints)
        {
            if(currentSkillPoints >= (currentLevel * 50))
            {
                currentLevel++;
            }

            if(currentLevel > 0 && currentLevel < 3)
            {
                currentDifficulty = Difficulty.Easy;
            }
            else if(currentLevel >= 3 && currentLevel < 5)
            {
                currentDifficulty = Difficulty.Medium;
            }
            else if(currentLevel > 5)
            {
                currentDifficulty = Difficulty.Hard;
            }

            handleHUDUpdate.Invoke(currentSkillPoints, currentLevel);
        }
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard

    }


}

