using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Obs3Tween : MonoBehaviour
{
   public Transform obsIII;
   public float duration;
   
   public Transform cylender;
   public float cylenderduration;


   private void Awake()
   {
      ObsIIITween();
   }

   public void ObsIIITween()
   {
      //transform.DOLocalRotate(Vector3.forward*1,duration,0).SetLoops(-1,LoopType.Yoyo);
      transform.DOLocalRotate(new Vector3(0, -90, -85), duration).SetLoops(-1, LoopType.Yoyo);
      cylender.DOLocalRotate(new Vector3(360,90,0),cylenderduration,RotateMode.FastBeyond360).SetEase(Ease.Linear)
         .SetLoops(-1,LoopType.Incremental);
   }

}
