using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using FirebaseWebGL.Scripts.FirebaseBridge;
using UnityEngine;
using UnityEngine.Video;

public class TestVideo : MonoBehaviour
{

    // Start is called before the first frame update
    VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        //FirebaseStorage.GetURL("2022-06-10 23-48-50.mp4", "Sphere", "Test", "TestError");
        //FirebaseStorage.DownloadFile("2022-06-10 23-48-50.mp4", "Sphere", "TestV", "TestVError");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey && videoPlayer.url != "")
        {
            videoPlayer.Play();
        }
    }
    public void Test(string str)
    {

        //var bytes = Convert.FromBase64String(str);
        videoPlayer.url = str;
        //videoPlayer.Play();
        Debug.Log("Test:" + str + "Good");
    }
    public void TestError(string str)
    {
        Debug.LogError("Error:" + str);
    }
    public void TestV(string str)
    {

        Debug.Log("TestV:" + str);
    }
    public void TestVError(string str)
    {
        Debug.LogError("ErrorV:" + str);
    }
}
