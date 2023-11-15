using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer redLight;
    public SpriteRenderer yellowLight;
    public SpriteRenderer greenLight;

    public int currentColorIndex = 0;

    public bool acik=false;

    public Canvas secondCanvas;

    void Start()
    {
        redLight.enabled= false;
        yellowLight.enabled= false;
        greenLight.enabled= false;
    }

    void OnMouseDown()
    {
        if (acik==true && currentColorIndex!=2)
        { 
            currentColorIndex = (currentColorIndex + 1) % 3;
            SetColor(currentColorIndex);
            Debug.Log(currentColorIndex);
         }

        if (currentColorIndex == 2)
        {
            secondCanvas.gameObject.SetActive(true); // SecondCanvas'� pasifle�tir
        }
    }

    void SetColor(int colorIndex)
    {
        // Renkleri belirli bir s�raya g�re ayarla
        redLight.enabled = colorIndex == 0;
        yellowLight.enabled = colorIndex == 1;
        greenLight.enabled = colorIndex == 2;
    }
}
