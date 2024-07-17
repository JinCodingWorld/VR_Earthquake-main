using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuggMove : MonoBehaviour
{
    public Transform xrOrigin;

    public Transform move;

    public GameObject textUI;
    // Start is called before the first frame update
    private void Start()
    {
        textUI.SetActive(true);
    }

    public void Duggfront()
    {
        StartCoroutine(MoveDu());
    }

    IEnumerator MoveDu()
    {
        textUI.SetActive(false);
        yield return new WaitForSeconds(2f);
        xrOrigin.DOMove(move.position, 1f);
        xrOrigin.DOMove(move.rotation.eulerAngles, 1f);
        yield return new WaitForSeconds(3f);
        GameManager.instance.FadeOut();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(5);
    }
}
