using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCreate : MonoBehaviour
{
    public Material material;
    public int index = 0;
    public bool isImageDetected;
    
  

    // Start is called before the first frame update
    void Start()
    {
        RotateImages();
        isImageDetected = false;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().Pause();
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

            if (index > 413)
            {
                return;
            }
        }

      
        Invoke(nameof(RotateImages), 0.08f);
    }

    

   
}
