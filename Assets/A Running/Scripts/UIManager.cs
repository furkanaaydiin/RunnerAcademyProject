using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace A_Running.Scripts
{
    public class UIManager : MonoBehaviour
    {
    
        public AnimatorControllers animatorControllers;

        public int score;
        public int maxScore;
        public TextMeshProUGUI coinText,
            scoreTextGOPanel,
            scoreTextlosePanel
            ,scoreTextWinPanel;

        public GameObject coinPanel;
        public GameObject gameOverPanel;
        public GameObject losePanel;
        public GameObject winPanel;

        public Slider coinSleder;
        public float coinMaxSlider;

        [SerializeField] private Button restartButton1;
        [SerializeField] private Button restartButton2;
        [SerializeField] private Button restartButton3;
        private void Awake()
        {
            restartButton1.onClick.AddListener(RestartGame);
            restartButton2.onClick.AddListener(RestartGame);
            restartButton3.onClick.AddListener(RestartGame);
        }
        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        private void Update()
        {
            coinSleder.value = coinMaxSlider;
        }
        public void CoinSleder() 
        {
            coinMaxSlider += 1f;
        }
        public void AddCoin()
        {
            score++;
            coinText.text = score.ToString();
            scoreTextGOPanel.text = score.ToString();
            scoreTextlosePanel.text = score.ToString();
            scoreTextWinPanel.text = score.ToString();
        }
        public void EndScoreStatus()
        {
            if (score >= maxScore && coinMaxSlider >= 20 )
            {
                animatorControllers.WinAnim();
            }
            else
            { 
                animatorControllers.LoseAnim();
            }
        }

        public void SceneLonding()
        {
            SceneManager.LoadScene(1);
        }
   

    

    
    }
}
