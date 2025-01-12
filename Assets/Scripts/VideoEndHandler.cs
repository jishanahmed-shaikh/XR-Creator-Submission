using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEndHandler : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += OnVideoPrepared;
        if (videoPlayer != null)
        {
            Debug.Log("VideoPlayer component found!");
            videoPlayer.loopPointReached += OnVideoEnd;
        }
        else
        {
            Debug.LogError("VideoPlayer component is missing!");
        }
    }

    private void OnVideoPrepared(VideoPlayer vp)
    {
        videoPlayer.Play();
    }
    
    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("Video ended. Attempting to load HomeScreen...");
        SceneManager.LoadScene("2HomeScreen");
    }

}
