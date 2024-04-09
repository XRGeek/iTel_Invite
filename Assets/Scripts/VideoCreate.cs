using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCreate : MonoBehaviour
{
    public Material material;
    public int index = 0;
    public bool isImageDetected;

    public GameObject[] texts;


    // Start is called before the first frame update
    void Start()
    {
        RotateImages();
        isImageDetected = false;
        foreach (GameObject text in texts)
        {
            text.SetActive(false);
        }
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

            if (index==52)
            {
                TurnOnText(0);
            }
            if (index == 90)
            {
                TurnOnText(1);
            }
            if (index == 130)
            {
                TurnOnText(2);
            }
            if (index == 170)
            {
                TurnOnText(3);
            }

            if (index == 210)
            {
                TurnOnText(4);
            }

            if (index == 240)
            {
                TurnOnText(5);
            }
            if (index == 255)
            {
                TurnOnText(6);
            }
            if (index == 260)
            {
                TurnOnText(7);
            }

           

            if (index > 331)
            {
                return;
            }
        }

      
        Invoke(nameof(RotateImages), 0.05f);
    }

    void TurnOnText(int index)
    {
        foreach (GameObject text in texts)
        {
            text.SetActive(false);
        }
        texts[index].SetActive(true);
    }
}
