using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Elevator : MonoBehaviour
{
    public Transform elevator;          // 엘레베이터

    public GameObject beforeImage;      // 이전창 UI

    void Start()
    {
        beforeImage.SetActive(false);   // 이전 이미지 끄고
        StartCoroutine(moveElav());
    }

    // Update is called once per frame
    IEnumerator moveElav()              // 엘레베이터 움직임 사실 카메라 움직임
    {
        yield return new WaitForSeconds(0.3f);
        transform.DOShakePosition(3);   // 카메라 흔듬
        yield return new WaitForSeconds(3.0f);
        beforeImage.SetActive(true);    // 이전 UI
    }
}
