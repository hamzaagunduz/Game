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
        firstCanvas.gameObject.SetActive(false); // FirstCanvas'� aktifle�tir
        secondCanvas.gameObject.SetActive(false); // SecondCanvas'� pasifle�tir
        thirdCanvas.gameObject.SetActive(true); // SecondCanvas'� pasifle�tir
    }
}
