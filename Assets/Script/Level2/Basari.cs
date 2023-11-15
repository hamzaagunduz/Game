using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basari : MonoBehaviour
{
    public Canvas firstCanvas;
    public Canvas secondCanvas;
    public Canvas thirdCanvas;
    void OnMouseDown()
    {
        firstCanvas.gameObject.SetActive(false); // FirstCanvas'ý aktifleþtir
        secondCanvas.gameObject.SetActive(false); // SecondCanvas'ý pasifleþtir
        thirdCanvas.gameObject.SetActive(true); // SecondCanvas'ý pasifleþtir
    }
}
