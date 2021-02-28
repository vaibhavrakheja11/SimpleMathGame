using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace DropIceCream
{
    public class HeaderUI : MonoBehaviour
    {
       [SerializeField] 
        TextMeshProUGUI m_SkillString;

        [SerializeField] 
        TextMeshProUGUI m_LevelString;

        [SerializeField] 
        TextMeshProUGUI questionDifficultyString;
        
        void Start()
        {
            LevelManager.handleHUDUpdate += UpdateHUD;
            UpdateHUD(GameController.Instance.skillPointManager.currentSkillPoint, GameController.Instance.levelManager.currentLevel);
        }

        void UpdateHUD(int skill, int level)
        {
            m_SkillString.text = skill.ToString();
            m_LevelString.text = level.ToString();
            questionDifficultyString.text = GameController.Instance.levelManager.currentDifficulty.ToString();
        }
    }

}
