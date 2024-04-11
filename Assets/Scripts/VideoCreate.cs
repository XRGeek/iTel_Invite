using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoCreate : MonoBehaviour
{
    public Material material;
    public int index = 0;
    public bool isImageDetected;
    
    public Transform finalPosition;

    public GameObject[] texts;
    public Transform[] textsTargets;

    // Start is called before the first frame update
    void Start()
    {
        RotateImages();
        isImageDetected = false;
        
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
                iTween.MoveTo(texts[0], textsTargets[0].position, 1.5f);
            }

            if (index == 92)
            {
                iTween.MoveTo(texts[1], textsTargets[1].position, 1.5f);// 1_Introduction Move In
                iTween.MoveTo(texts[0], finalPosition.position, 5);
            }

            if (index == 107)
            {
               
                iTween.MoveTo(texts[1], finalPosition.position, 5);  // 1_Introduction Move away
            }

            if (index == 117)
            {

                iTween.MoveTo(texts[3], textsTargets[3].position, 1.5f);  // Itel Logo Move In
            }



            if (index == 127)
            {
                iTween.MoveTo(texts[2], textsTargets[2].position, 1.5f); // 2_Itel rebranding and future plans -- move in
            }


            if (index == 138)
            {
                iTween.MoveTo(texts[2], finalPosition.position, 5); // 2_Itel rebranding and future plans and Itel logo -- move out
                iTween.MoveTo(texts[3], finalPosition.position, 5);
            }

            if (index == 142)
            {
                iTween.MoveTo(texts[4], textsTargets[4].position, 1.5f); // 3_Sizzling hot reveal of -- move in
            }

            if (index == 155)
            {
                iTween.MoveTo(texts[4], finalPosition.position, 5); // 3_Sizzling hot reveal of -- move out
            }


            if (index == 156)
            {
                iTween.MoveTo(texts[9], textsTargets[9].position, 1.5f); // 8_S24 -- move in
            }

            if (index == 168)
            {
                iTween.MoveTo(texts[9], finalPosition.position, 5); // 8_S24 -- move out
            }

            if (index == 170)
            {
                iTween.MoveTo(texts[5], textsTargets[5].position, 1.5f); // 4_Its gonna be epic! -- move in
            }

            if (index == 191)
            {
                iTween.MoveTo(texts[5], finalPosition.position, 5); // 4_Its gonna be epic! -- move out
            }

            if (index == 223)
            {
                iTween.MoveTo(texts[6], textsTargets[6].position, 1.5f); // 5_Hands-on fun experience of all our smartphones and accessories -- move in
            }

            if (index == 255)
            {
                iTween.MoveTo(texts[6], finalPosition.position, 5); // 5_Hands-on fun experience of all our smartphones and accessories -- move out
            }

            if (index == 262)
            {
                iTween.MoveTo(texts[7], textsTargets[7].position, 1.5f); // 6_Delicious eats and drinks at The Royal Kitchen, Lahore Fort -- move in
            }

            if (index == 279)
            {
                iTween.MoveTo(texts[7], finalPosition.position, 5); // 6_Delicious eats and drinks at The Royal Kitchen, Lahore Fort -- move out
            }

            if (index == 281)
            {
                iTween.MoveTo(texts[8], textsTargets[8].position, 1.5f); // 7_Networking with cool people and the Itel crew -- move in
            }

            if (index == 311)
            {
                iTween.MoveTo(texts[8], finalPosition.position, 5); // 7_Networking with cool people and the Itel crew -- move out
            }


         


            if (index > 331)
            {
                return;
            }
        }

      
        Invoke(nameof(RotateImages), 0.2f);
    }

    

   
}
