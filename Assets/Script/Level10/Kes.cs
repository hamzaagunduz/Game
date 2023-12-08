using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kes : MonoBehaviour
{

    public int kel;
    public SpriteRenderer resim2;

    public Canvas secondCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Man"))
        {

            collision.gameObject.SetActive(false);
            kel++;
           
            if(kel==3)
            {
                resim2.gameObject.SetActive(true);
                Invoke("NextCanvas", 2f);

            }

        }

    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }
}
