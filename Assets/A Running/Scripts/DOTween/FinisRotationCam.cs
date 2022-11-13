using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FinisRotationCam : MonoBehaviour
{
   public Transform finishGameObjects;
   public float duration;
   public void FinisRotation()
   {
      
      finishGameObjects.DOLocalRotate(new Vector3(0, 360, 0),duration,RotateMode.WorldAxisAdd).SetEase(Ease.Linear).SetLoops(-1,LoopType.Incremental);

   }
}
