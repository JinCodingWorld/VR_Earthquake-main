using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using Unity.Android.Types;

public class RemoteControl : MonoBehaviour
{
    public VideoPlayer video;
    
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            rb.isKinematic = false;
            video.Pause();
            Invoke("SceneChange", 3f);
        }
    }

    private void SceneChange()
    {
        SceneManager.LoadScene(2);
    }

}
