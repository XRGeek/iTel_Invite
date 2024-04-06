using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCreate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RotateImages();
    }

    public Material material;
    public int index = 0;
    // Update is called once per frame

    void RotateImages()
    {
        
        Texture tex = Resources.Load<Texture>("0-"+index);
        material.mainTexture = tex;
        index++;
        if (index>677)
        {
            return;
        }
        Invoke(nameof(RotateImages), 0.05f);
    }
}
