using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Elevator : MonoBehaviour
{
    public Transform elevator;          // ����������

    public GameObject beforeImage;      // ����â UI

    void Start()
    {
        beforeImage.SetActive(false);   // ���� �̹��� ����
        StartCoroutine(moveElav());
    }

    // Update is called once per frame
    IEnumerator moveElav()              // ���������� ������ ��� ī�޶� ������
    {
        yield return new WaitForSeconds(0.3f);
        transform.DOShakePosition(3);   // ī�޶� ���
        yield return new WaitForSeconds(3.0f);
        beforeImage.SetActive(true);    // ���� UI
    }
}
