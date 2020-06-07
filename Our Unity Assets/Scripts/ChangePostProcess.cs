using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ChangePostProcess : MonoBehaviour
{

    public PostProcessProfile normal, fx;
    private PostProcessVolume camImgFx;

    // Start is called before the first frame update
    void Start()
    {
        camImgFx = FindObjectOfType<PostProcessVolume>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            camImgFx.profile = fx;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            camImgFx.profile = normal;
        }
    }
}
