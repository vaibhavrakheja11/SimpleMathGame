using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


namespace DropIceCream
{
    public class QuestionAreaUIController : MonoBehaviour
    {
            [SerializeField] 
            TextMeshProUGUI m_missingWordString;

            [SerializeField] 
            TextMeshProUGUI m_firstIntString;

            [SerializeField] 
            TextMeshProUGUI m_secondIntString;

            [SerializeField] 
            TextMeshProUGUI m_opratorString;

            public GameObject SimpleMathPanel;
            public GameObject MissingWordPanel;


            public void DisplayMissingWord(string word)
            {
                SimpleMathPanel.SetActive(false);
                MissingWordPanel.SetActive(true);
                m_missingWordString.text = word;
            }

            public void DisplaySimpleMath(int a, int b, string opr)
            {
                SimpleMathPanel.SetActive(true);
                MissingWordPanel.SetActive(false);
                m_firstIntString.text = a.ToString();
                m_secondIntString.text = b.ToString();
                m_opratorString.text = opr;
            }

            public void DisplayQuestion(Question question)
            {
                switch(question.questionType)
                {
                    case QuestionType.MissingWord:
                            DisplayMissingWord(question.maskedWord);
                            break;
                    case QuestionType.SimpleMaths:
                            DisplaySimpleMath(question.firtInt,question.secondInt,question.strOperator);
                            break;
                }
            }
    }
}
