using UnityEngine;
using UnityEngine.UI;

namespace Parsifall
{
    public class ChoiceMaking : MonoBehaviour
    {
        [SerializeField] private Text _statement;

        private Options _options;

        public void SetStatement(float index)
        {
            _options = (Options) (int) index;
        }

        public void Choose()
        {
            var statement = _statement.text;

            GameManager.Instance.Choose(_options, statement);
        }
    }
}