using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class Move : MonoBehaviour
{
    public Transform xrOrigin;

    public Transform move1;
    public Transform move2;
    public Transform move3;
    public Transform move4;
    public Transform move5;
    public Transform move6;
    public Transform move7;

    private void Start()
    {

    }

    public void Elevator()
    {
        StartCoroutine(MoveElevator());
    }

    public void Stairs()
    {
        StartCoroutine(MoveStairs());
    }

    IEnumerator MoveElevator()
    {
        GameManager.instance.choiceImage.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        xrOrigin.DOMove(move1.position, 3.0f);
        xrOrigin.DORotate(move1.rotation.eulerAngles, 3.0f);
        yield return new WaitForSeconds(5.0f);
        GameManager.instance.FadeOut();
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(6);

    }

    IEnumerator MoveStairs()
    {
        GameManager.instance.choiceImage.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        xrOrigin.DOMove(move2.position, 3.0f);
        xrOrigin.DORotate(move2.rotation.eulerAngles, 3.0f);
        yield return new WaitForSeconds(3.0f);
        xrOrigin.DOMove(move3.position, 1f);
        xrOrigin.DORotate(move3.rotation.eulerAngles, 1.0f);
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DOMove(move4.position, 1f);
        xrOrigin.DORotate(move4.rotation.eulerAngles, 1f);
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DOMove(move5.position, 1f);
        xrOrigin.DORotate(move5.rotation.eulerAngles, 1.5f);
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DOMove(move6.position, 1f);
        xrOrigin.DORotate(move6.rotation.eulerAngles, 1f);
        yield return new WaitForSeconds(0.8f);
        xrOrigin.DOMove(move7.position, 1f);
        xrOrigin.DORotate(move7.rotation.eulerAngles, 1f);
        yield return new WaitForSeconds(2f);
        GameManager.instance.FadeOut();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(7);
    }
}
