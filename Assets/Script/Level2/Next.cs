using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public Canvas firstCanvas;
    public Canvas secondCanvas;

    // Update is called once per frame
    public void next()
    {
        firstCanvas.gameObject.SetActive(false); // FirstCanvas'ý aktifleþtir
        secondCanvas.gameObject.SetActive(true); 
    }
}
