using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ConservativeTween : MonoBehaviour
{

    public Transform armParen;
    public float duration;
    public float gpos;

    public Transform cyliner;
    public float cylinerDuration;
    
    public bool direction;

    private void Awake()
    {
        ConservativeTwn();
    }

    public void ConservativeTwn()
    {
        if (direction)
        {
            armParen.DOLocalMoveX(gpos, duration).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
        }
        else
        {
            armParen.DOLocalMoveX(gpos, duration).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
        }

        cyliner.DOLocalRotate(new Vector3(360, 90, 0), cylinerDuration, RotateMode.FastBeyond360).SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);


    }
}
