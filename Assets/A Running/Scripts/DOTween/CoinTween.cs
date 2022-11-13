using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinTween : MonoBehaviour
{
   public Transform coinTransform;
   public float duration;


   private void Awake()
   {
      CoinRotationTween();
   }

   public void CoinRotationTween()
   {
      coinTransform.DOLocalRotate(new Vector3(-90, 0, 360), duration, RotateMode.FastBeyond360).SetEase(Ease.Linear)
         .SetLoops(-1,LoopType.Incremental);
   }
}
