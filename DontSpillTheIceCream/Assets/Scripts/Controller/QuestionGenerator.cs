using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DropIceCream
{
    public class QuestionGenerator : MonoBehaviour
    {
        Question m_question;

        string[] easyWords = { "Bold", "Think", "Friend", "Pony", "Fall", "Easy" };
        string[] mediumWords = { "Bold", "Think", "Friend", "Pony", "Fall", "Easy" };
        string[] hardWords = { "Bold", "Think", "Friend", "Pony", "Fall", "Easy" };
        Tuple<int, int> easyRange= new Tuple<int,int>(0,100);
        Tuple<int, int> mediumRange= new Tuple<int,int>(300,1000);
        Tuple<int, int> hardRange= new Tuple<int,int>(1000,10000);


        public Question GenerateMissiongWordQuestion()
        {
            m_question = new Question();
            m_question.word = CreateRandomWordCombination(easyWords);
            Tuple<string,char> missingWord = GetMaskedWord(m_question.word);
            m_question.questionType = QuestionType.MissingWord;
            m_question.missingWordResult = missingWord.Item2;
            m_question.maskedWord = missingWord.Item1;
            return m_question;
        }

        public Question GeneratSimpleMathQuestion()
        {
            m_question = new Question();
            Tuple<int,int> simpelMath = CreateRandomSimpleMathCombination(easyRange);;
            m_question.questionType = QuestionType.SimpleMaths;
            m_question.firtInt = simpelMath.Item1;
            m_question.secondInt = simpelMath.Item2;
            switch(UnityEngine.Random.Range(0,3))
            {
                case 0:
                    m_question.strOperator = "+";
                    m_question.simpleMathResult = m_question.firtInt + m_question.secondInt;
                    break;
                case 1:
                    m_question.strOperator = "-";
                    m_question.simpleMathResult = m_question.firtInt - m_question.secondInt;
                    break;
                case 2:
                    m_question.strOperator = "x";
                    m_question.simpleMathResult = m_question.firtInt * m_question.secondInt;
                    break;
                case 3:
                    m_question.strOperator = "/";
                    m_question.simpleMathResult = m_question.firtInt / m_question.secondInt;
                    break;
            }
            return m_question;
        }

        public static string CreateRandomWordCombination(string[] words)
        {
            //Create combination of word + number
            string randomString = words[UnityEngine.Random.Range(0, words.Length - 1)];

            return randomString;
        }

        public static Tuple<int, int> CreateRandomSimpleMathCombination(Tuple<int,int> numbers)
        {
            
            //Random number from - to
            Tuple<int,int> simepleMathCombination = new Tuple<int, int>(UnityEngine.Random.Range(numbers.Item1, numbers.Item2),UnityEngine.Random.Range(numbers.Item1, numbers.Item2));

            return simepleMathCombination;
        }
        
        Tuple<string,char> GetMaskedWord(string word)
        {
            int index = UnityEngine.Random.Range(0, word.Length - 1);
            char[] ch = word.ToCharArray();
            char c = ch[index];
            ch[index] = '*'; // index starts at 0!
            string newstring = new string (ch);
            return new Tuple<string, char>(newstring, Char.ToLower(c));
        }
        
    }
}
