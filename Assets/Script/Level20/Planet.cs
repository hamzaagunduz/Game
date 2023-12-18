using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public int sayi=0;
    public bool gun=false;

    public SpriteRenderer resim1;
    public SpriteRenderer resim2;
    public SpriteRenderer resim3;
    public SpriteRenderer resim4;

    public Canvas secondCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Kus"))
        {
            if (gun == true&sayi==1)
            {
                resim2.enabled = false; 
                resim3.enabled=true;
                sayi++;
                Destroy(collision.gameObject);


            }
          
        }
        if (collision.gameObject.CompareTag("Et"))
        {
            if (gun == true & sayi == 2)
            {
                resim3.enabled = false;
                resim4.enabled = true;
                sayi++;
                Destroy(collision.gameObject);
                Invoke("Canvas", 2f);


            }

        }
    }

    void Canvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }


}
