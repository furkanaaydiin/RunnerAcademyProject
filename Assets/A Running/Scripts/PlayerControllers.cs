using DG.Tweening;
using UnityEngine;

namespace A_Running.Scripts
{
    public class PlayerControllers : MonoBehaviour
    {
        public float runningSpeed;
        float touchXDelta = 0;
        float newX = 0;
        public float xSpeed;
        public float limitX;
        public  bool gameStart;
    
        //max scale min scale
        public Transform player;
        private Tween _playerSizeTween;

        public void RunSpeedZero()
        {
            runningSpeed = 0;
        }
        void FixedUpdate()
        {
            SwipeCheck();
        }

        private void SwipeCheck()
        {
            if (gameStart)
            {
                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
                }
                else if (Input.GetMouseButton(0))
                {
                    touchXDelta = Input.GetAxis("Mouse X");
                }
                else
                {
                    touchXDelta = 0;
                }

                var position = transform.position;
                newX = position.x + xSpeed * touchXDelta * Time.deltaTime;
                newX = Mathf.Clamp(newX, -limitX, limitX);
           
                Vector3 newPosition = new Vector3(newX, position.y, position.z + runningSpeed * Time.deltaTime); position = newPosition;
                transform.position = position;
            }
        }
    
        public void ChangePlayerSize(bool isSizeUp)
        {
            var targetScale = player.localScale + (isSizeUp ? Vector3.one : -Vector3.one) * (isSizeUp ? 0.04f : 0.03f);
            targetScale = new Vector3
            (Mathf.Clamp(targetScale.x,0.1f,0.32f), 
                Mathf.Clamp(targetScale.y,0.1f,0.32f),
                Mathf.Clamp(targetScale.z,0.1f,0.32f));
            _playerSizeTween?.Kill();
            _playerSizeTween = player.DOScale(targetScale, 0.2f).SetEase(Ease.InBack);
        }
    
    
    }
}
