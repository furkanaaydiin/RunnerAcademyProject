using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEditor.UIElements;
using UnityEngine;

public class Osb2Tween : MonoBehaviour
{
    // obstacle 2 
    public Transform obsIITransform;
    public float duration;
    public bool direction;
    public float goPos;

    private void Awake()
    {
        ObstacleII();
    }

    public void ObstacleII()
    {
        if (direction)
        {
            obsIITransform.DOLocalMoveX(goPos, duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
            obsIITransform.DORotate(new Vector3(-90, 360, 0), 3f, RotateMode.FastBeyond360).SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Incremental);

        }
        else
        {
            obsIITransform.DOLocalMoveX(goPos, duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
            obsIITransform.DORotate(new Vector3(-90, 360, 0), 3f, RotateMode.FastBeyond360).SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Incremental);

        }


    }

}
