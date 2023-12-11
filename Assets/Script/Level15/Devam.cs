using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devam : MonoBehaviour
{
    // Start is called before the first frame update
    public int puzzle=0;

    public Canvas secondCanvas;


    // Update is called once per frame
 
    public void dene()
    {
        Invoke("NextCanvas", 2f);

    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }
}
