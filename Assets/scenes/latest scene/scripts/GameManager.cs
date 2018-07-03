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
    }
}