using UnityEngine;
using System.Collections;
using MarlonLuan.MLFramework.Unity.Scripts;

public class Cena_Video : MonoBehaviour
{
    //#if UNITY_ANDROID
    //#else
    public MovieTexture video;
    //#endif

    public Plane plano;
    // Use this for initialization
    void Start()
    {
        //plano
        //      #if UNITY_ANDROID
        //     Handheld.PlayFullScreenMovie("");
        //#else
        transform.GetComponent<Renderer>().material.mainTexture = video;
        video.loop = true;
        video.Play();
        //#endif
    }

    // Update is called once per frame
    void Update()
    {

    }
}
