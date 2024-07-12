using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public GameObject image;
    public Image fadeImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeOut()
    {
        image.SetActive(true);
        fadeImage.color = new Color(0, 0, 0, 0);

        fadeImage.DOFade(1.0f, 3.0f);
    }
}
