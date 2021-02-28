using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DropIceCream
{
    public class Question
    {
        public QuestionType questionType;

        public QuestionDifficulty difficulty;

        public string word = null;
        public string maskedWord = null;

        public int firtInt,secondInt = -1;

        public int simpleMathResult = -1;
        public char missingWordResult;
        public string strOperator = null;

    }

    public enum QuestionType
    {
        SimpleMaths,
        MissingWord
    }

    public enum QuestionDifficulty
    {
        Easy,
        Medium,
        Hard
    }

}

