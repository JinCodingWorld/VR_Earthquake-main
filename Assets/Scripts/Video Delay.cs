using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoDelay : MonoBehaviour
{
    public VideoPlayer video;
    public void delayvideo()
    {
        video.Play();
    }

    private void Start()
    {
        Invoke("delayvideo", 4f);
    }
}
