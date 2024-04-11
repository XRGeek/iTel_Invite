using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCreate : MonoBehaviour
{
    public Material material;
    public int index = 0;
    public bool isImageDetected;

    private AudioSource music;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        RotateImages();
        isImageDetected = false;
        music = GetComponent<AudioSource>();
        currentTime = 0;
    }

    public void SetImageDetectionStatus(bool status)
    {
        isImageDetected = status;
    }
    
    // Update is called once per frame

    void RotateImages()
    {
        if (isImageDetected)
        {
            Texture tex = Resources.Load<Texture>("0-" + index);
            material.mainTexture = tex;
            index++;

            if (index > 411)
            {
                return;
            }
        }

      
        Invoke(nameof(RotateImages), 0.08f);
    }

    public void PlayAudio()
    {
        music.Play();
        music.time = currentTime;

    }
    public void PauseAudio()
    {
        currentTime = music.time;
        music.Stop();
    }




}
