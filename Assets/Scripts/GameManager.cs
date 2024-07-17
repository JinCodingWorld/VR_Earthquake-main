using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject choiceImage;      // 선택창 UI


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public GameObject image;            // 끄는 이미지
    public Image fadeImage;
    void Start()
    {
        if (SceneManager.sceneCount == 5)
        {
            choiceImage.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FadeOut()               // 불끄는 이미지
    {
        image.SetActive(true);
        fadeImage.color = new Color(0, 0, 0, 0);

        fadeImage.DOFade(1.0f, 3.0f);
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}

