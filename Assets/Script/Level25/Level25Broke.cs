using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level25Broke : MonoBehaviour
{
    public SpriteRenderer resim1;
    public SpriteRenderer resim2;
    public Canvas secondCanvas;

    public int giris=0;
    void Start()
    {

    }

  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("x");

        if (collision.gameObject.CompareTag("Kus"))
        {
            giris++;
            if (giris == 2)
            {
                resim1.enabled = false;
                resim2.enabled = true;
                Invoke("Canvas", 2f);

            }

        }
    }

    void Canvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }

}
