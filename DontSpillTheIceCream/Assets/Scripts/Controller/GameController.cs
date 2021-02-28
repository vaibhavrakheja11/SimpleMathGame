using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DropIceCream
{
    public class GameController : MonoBehaviour
    {
        private static GameController _instance;

        public static GameController Instance { get { return _instance; } }

        [SerializeField]
        public GameInitiator GameInit;

        [SerializeField]
        public ViewController viewController;

        public QuestionGenerator  questionGenerator;

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            } else {
                _instance = this;
            }
        }
    }
}

