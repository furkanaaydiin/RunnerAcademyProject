using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Osb1Tween : MonoBehaviour
{
    // obstacle 1 
    public Transform obsITransform;
    public float duration;
    public float goPos;
    public bool direction;

    private void Awake()
    {
        ObstacleI();
    }

    public void ObstacleI()
    {
        if (direction)
        {
            obsITransform.DOLocalMoveX(goPos, duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
            obsITransform.DOLocalRotate(new Vector3(0, 360, 0), 3f, RotateMode.FastBeyond360).SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Incremental);
        }
        else
        {
            obsITransform.DOLocalMoveX(goPos, duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
            obsITransform.DOLocalRotate(new Vector3(0, 360, 0), 3f, RotateMode.FastBeyond360).SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Incremental);
        }
        



    }

}
    
