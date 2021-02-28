using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

namespace DropIceCream
{
   public class PlayAreamUI : MonoBehaviour
    {
        public List<Button> BtnList = new List<Button>();
        public static event Action<string> handleResponseEvent;
        
        public void DisplayIntOptions(int answer)
        {
            int index = UnityEngine.Random.Range(0,4);
            for(int i = 0; i< BtnList.Count; i++)
            {
                int rndNum = UnityEngine.Random.Range(answer - 200, answer + 200);
                if(i!=index)
                BtnList[i].GetComponentInChildren<Text>().text = rndNum.ToString();
                else
                BtnList[i].GetComponentInChildren<Text>().text = answer.ToString();
            }
        }

        public void DisplayCharOptions(char answer)
        {
            
            int rndBtnIndex = UnityEngine.Random.Range(0,4);
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            char[] clphaChar = alpha.ToCharArray();
            for(int i = 0; i < BtnList.Count; i++)
            {
                int index = UnityEngine.Random.Range(0,25);
                if(i!=rndBtnIndex)
                BtnList[i].GetComponentInChildren<Text>().text = clphaChar[index].ToString();
                else
                BtnList[i].GetComponentInChildren<Text>().text = answer.ToString();
            }
        }

        public void HandleButtonClick()
        {
            handleResponseEvent.Invoke(EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text.ToString());
        }
    } 
}

