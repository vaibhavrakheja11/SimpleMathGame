using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DropIceCream
{
    public class GameInitiator : MonoBehaviour
    {
        Question question;
        // Start is called before the first frame update
        void Start()
        {

            NextQuestion();
           PlayAreamUI.handleResponseEvent += CheckResults;
        }

        void NextQuestion()
        {
            switch(UnityEngine.Random.Range(0,2))
            {
                case 0:
                    GenerateMissingWordQuestion();
                    break;
                case 1:
                    GenerateSimpleMathQuestion();
                    break;
                default:
                    GenerateSimpleMathQuestion();
                    break;
            }
            
        }

        void GenerateMissingWordQuestion()
        {
            question = GameController.Instance.questionGenerator.GenerateMissiongWordQuestion();
            GameController.Instance.viewController.QuestionAreaUI.DisplayQuestion(question);
            GameController.Instance.viewController.PlayAreaUI.DisplayCharOptions(question.missingWordResult);
        }

        void GenerateSimpleMathQuestion()
        {
            question = GameController.Instance.questionGenerator.GeneratSimpleMathQuestion();
            GameController.Instance.viewController.QuestionAreaUI.DisplayQuestion(question);
            GameController.Instance.viewController.PlayAreaUI.DisplayIntOptions(question.simpleMathResult);
        }

        public void CheckResults(string result)
        {
            if(question.questionType == QuestionType.MissingWord)
            {
                if(result.ToLower().Equals(question.missingWordResult.ToString().ToLower()))
                {
                    Debug.Log("Correct Answer");
                    GameController.Instance.skillPointManager.IncreaseSkillPoints();
                    NextQuestion();
                }
                else
                {
                    Debug.Log("Incorrect Answer");
                }
            }
            else if(question.questionType == QuestionType.SimpleMaths)
            {
                if(Int32.Parse(result) == question.simpleMathResult)
                {
                    Debug.Log("Correct Answer");
                    GameController.Instance.skillPointManager.IncreaseSkillPoints();
                    NextQuestion();
                }
                else
                {
                    Debug.Log("Incorrect Answer");
                }
            }
        }
    }
}
