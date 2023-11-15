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
    }

    void SetColor(int colorIndex)
    {
        // Renkleri belirli bir sýraya göre ayarla
        redLight.enabled = colorIndex == 0;
        yellowLight.enabled = colorIndex == 1;
        greenLight.enabled = colorIndex == 2;
    }
}
