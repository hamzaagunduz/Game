using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    public int giris=0;

    public Canvas secondCanvas;

   

    public void NextCanvas()
    {
        Invoke("Canvas", 2f);
    }
    void Canvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }
}
