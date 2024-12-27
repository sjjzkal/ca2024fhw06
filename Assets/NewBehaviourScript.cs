using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject videoPlayer;
    // Start is called before the first frame update
   
    public void VideoStart()
    { 
        videoPlayer.SetActive(true);
    }


    // Update is called once per frame
   
}
