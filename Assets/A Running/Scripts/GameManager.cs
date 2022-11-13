using UnityEngine;

namespace A_Running.Scripts
{
    public class GameManager : MonoBehaviour
    {

        public GameObject payerFollowCam;
        public GameObject startCamera;
        public GameObject finishCamera;
        public FinisRotationCam finisRotationCam;
        
        public PlayerControllers _playerControllers;
        public AnimatorControllers animatorControllers;
        public UIManager uIManager;

        public ParticleSystem coinParticle;
        public ParticleSystem fireworkEndParticle ,fireworkEndParticle2;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("coin"))
            {
                uIManager.AddCoin();
                coinParticle.transform.position = other.transform.position;
                coinParticle.Play();
                Destroy(other.gameObject);
                uIManager.CoinSleder();

            }
            else if (other.CompareTag("end"))
            {
                _playerControllers.RunSpeedZero();
                finisRotationCam.FinisRotation();
                finishCamera.SetActive(true);
                uIManager.EndScoreStatus();
                uIManager.coinPanel.SetActive(false);
                if (uIManager.score >= uIManager.maxScore && uIManager.coinMaxSlider >= 20)
                {
                    uIManager.winPanel.SetActive(true);
                    fireworkEndParticle.Play();
                    fireworkEndParticle2.Play();
                }
                else
                {
                    uIManager.losePanel.SetActive(true);
                }
                
            }
            else if (other.CompareTag("positive"))
            {
                _playerControllers.ChangePlayerSize(true);
            }
            else if (other.CompareTag("negative"))
            {
                _playerControllers.ChangePlayerSize(false);
            }
        
        }
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("collision"))
            {
                _playerControllers.RunSpeedZero();
                animatorControllers.DeadAnim();
                uIManager.gameOverPanel.SetActive(true);
                uIManager.coinPanel.SetActive(false);
            
            }
        }
    
    
    }
}
