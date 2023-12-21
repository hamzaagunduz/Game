using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level24Up : MonoBehaviour
{
    public Canvas secondCanvas;

    void Start()
    {

    }

    // Update is called once per frame
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kus"))
        {
            Invoke("Canvas", 2f);

        }
    }
    void Canvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }

}
