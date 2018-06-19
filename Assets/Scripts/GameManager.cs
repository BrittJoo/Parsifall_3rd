using System.Collections.Generic;
using UnityEngine;

namespace Parsifall
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance
        {
            get { return _instance ? _instance : new GameObject("GameManager").AddComponent<GameManager>(); }
        }

        private readonly List<Choice> _choices = new List<Choice>();

        private static GameManager _instance;

        private void Awake()
        {
            if (_instance)
            {
                Destroy(gameObject);
                return;
            }

            _instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void Choose(Options options, string statement)
        {
            var index = _choices.Count + 1;

            var choice = new Choice
            {
                Index = index,
                Options = options,
                Statement = statement
            };

            _choices.Add(choice);
        }
    }
}