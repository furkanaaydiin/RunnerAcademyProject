using DG.Tweening;
using UnityEngine;

namespace A_Running.Scripts
{
   public class AnimatorControllers : MonoBehaviour
   {
  
   
      [SerializeField] public Animator playeranimator;
      [SerializeField] private RectTransform taptostart;
      [SerializeField] private RectTransform startmenu;
      public GameManager _gameManager;
      public PlayerControllers _playerControllers;

      private void Awake()
      {
         TapToStartAnimation();
      }
      private void StartRunAnimation()
      {
         playeranimator.CrossFade("Running",0.10f);
      }

      private void TapToStartAnimation()
      {
         taptostart.DOScale(Vector2.one * 1f, 1).SetLoops(-1, LoopType.Yoyo);
      }

      public void StartMenuAnim()
      {
         startmenu.DOScale(Vector2.zero, 1f);
         _playerControllers.gameStart = true;
         _gameManager.startCamera.SetActive(false);
         _gameManager.payerFollowCam.SetActive(true);

      }

      public void WinAnim()
      {
         playeranimator.SetBool("win",true);
      }
   
      public void LoseAnim()
      {
         playeranimator.SetBool("lose",true);
      }
   
      public void DeadAnim()
      {
         playeranimator.SetBool("dead",true);
      }
   
   }
}
