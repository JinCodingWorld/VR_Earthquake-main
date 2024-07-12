using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    public Transform xrOrigin;

    public Transform move1;
    public Transform move2;

    private void Start()
    {
        StartCoroutine(MoveStart());
    }

    IEnumerator MoveStart()
    {
        
        yield return new WaitForSeconds(4.0f);
        xrOrigin.DOMove(move1.position,6.0f);
        xrOrigin.DORotate(move1.rotation.eulerAngles, 5.0f);
        yield return new WaitForSeconds(7.0f);
        xrOrigin.DOMove(move2.position, 2.0f);
        xrOrigin.DORotate(move2.rotation.eulerAngles, 2.0f);
        GameManager.instance.FadeOut();

        
    }
}
