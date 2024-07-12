using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TableHide : MonoBehaviour
{
    public Transform xrOrigin;
    public Transform chair1;
    public Transform Table1;
    public Transform Moniter1;

    public GameObject startBtn;
    public GameObject Btn1;
    public GameObject Btn2;
    public GameObject Panel;

    Vector3 ChairPos;
    Vector3 TablePos;
    Vector3 moveVector;
    Vector3 angleX;
    Vector3 angleY;

    void Start()
    {
        ChairPos = chair1.position;
        TablePos = Table1.position;
        moveVector = new Vector3(TablePos.x - ChairPos.x, 0f, TablePos.z - ChairPos.z);
        angleX = new Vector3(45f, 0f, 0f);
        angleY = new Vector3(0f, 75f, 0f);

        Situation();
    }

    public IEnumerator Situation1()
    {
        startBtn.SetActive(false);


        chair1.position = ChairPos;
        xrOrigin.position = new Vector3(ChairPos.x, xrOrigin.position.y, ChairPos.z);
        xrOrigin.LookAt(Moniter1);

        yield return new WaitForSeconds(1.0f);
        xrOrigin.DOMove(xrOrigin.position - (moveVector / 2), 1.0f);
        chair1.DOMove(chair1.position - (moveVector / 2), 0.5f);
        yield return new WaitForSeconds(1.0f);
        xrOrigin.DORotate(xrOrigin.rotation.eulerAngles - angleY, 1.0f);
        yield return new WaitForSeconds(1.0f);
        xrOrigin.DORotate(xrOrigin.rotation.eulerAngles + angleY, 1.0f);
        yield return new WaitForSeconds(1.0f);
        xrOrigin.DORotate(xrOrigin.rotation.eulerAngles + angleY, 1.0f);
        yield return new WaitForSeconds(1.0f);
        xrOrigin.DORotate(xrOrigin.rotation.eulerAngles - angleY, 1.0f);
        yield return new WaitForSeconds(1.0f);
        
        Panel.SetActive(true);
        Btn1.SetActive(true);
        Btn2.SetActive(true);
        Time.timeScale = 0f;
        

    }

    public IEnumerator HideTable()
    {
        Panel.SetActive(false);
        Btn1.SetActive(false);
        Btn2.SetActive(false);

        Time.timeScale = 1.0f;

        yield return new WaitForSeconds(1.0f);
        xrOrigin.DORotate(xrOrigin.rotation.eulerAngles + angleX, 1.0f);
        chair1.DOMove(chair1.position + Vector3.left * 2, 0.5f);
        xrOrigin.DOMove(xrOrigin.position - Vector3.up * 1, 1.0f);
        yield return new WaitForSeconds(0.5f);
        xrOrigin.DOMove(xrOrigin.position + moveVector, 1.0f);
        yield return new WaitForSeconds(0.5f);
        xrOrigin.DORotate(xrOrigin.rotation.eulerAngles - angleX, 1.0f);
        yield return new WaitForSeconds(0.5f);
        xrOrigin.DORotate(xrOrigin.rotation.eulerAngles - angleY * 2, 1.0f);

        GameManager.instance.FadeOut();
    }

    public IEnumerator Searching()
    {
        Panel.SetActive(false);
        Btn1.SetActive(false);
        Btn2.SetActive(false);

        yield return new WaitForSeconds(1.0f); 
    }

    public void Situation()
    {
        StartCoroutine(Situation1());
    }

    public void HideOnTable()
    {
        StartCoroutine(HideTable());
    }

    public void SearchingAround()
    {
        StartCoroutine(Searching());
    }
}
