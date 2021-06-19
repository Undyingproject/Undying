using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skip : MonoBehaviour
{
    public GameObject Image;
    public GameObject camera;
    public GameObject diagman;
    public GameObject diagman2;
    public void SkipText()
    {
        Destroy(Image);
        Destroy(diagman);
        Destroy(diagman2);
        camera.SetActive(true);
    }
}
