using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Devam : MonoBehaviour
{
    public Canvas firstCanvas;
    public Canvas secondCanvas;
    public void devamEt()
    {
        firstCanvas.gameObject.SetActive(false); // FirstCanvas'� aktifle�tir
        secondCanvas.gameObject.SetActive(true); // SecondCanvas'� pasifle�tir
        Debug.Log("sad");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
