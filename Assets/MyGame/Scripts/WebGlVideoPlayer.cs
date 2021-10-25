using UnityEngine;
using UnityEngine.Video;

public class WebGlVideoPlayer : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private string videoFileName;


    private void Start()
    {
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
        Debug.Log("Start playing: video from source: " + videoPlayer.url);
        videoPlayer.isLooping = true;
        
    }

    public void StartTheVideo()
    {
        videoPlayer.Play();
        Debug.Log("video is playing: " + videoPlayer.isPlaying);
    }
}