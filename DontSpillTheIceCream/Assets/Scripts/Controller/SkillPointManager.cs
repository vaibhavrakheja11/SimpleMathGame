using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DropIceCream
{
    public class SkillPointManager : MonoBehaviour
    {
       const int IncrementSkillPoint = 10;

       public static event Action<int> handleSkillPointIncrease;

        public int currentSkillPoint = 0;

        public void IncreaseSkillPoints()
        {
            currentSkillPoint += IncrementSkillPoint;
            handleSkillPointIncrease.Invoke(currentSkillPoint);
        }
    }
}

