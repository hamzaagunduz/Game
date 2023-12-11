using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    public GameObject obje;

    public Canvas secondCanvas;

    public int para=0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Key") )
        {
            Debug.Log("colis girdi");

                obje.gameObject.GetComponent<Collider2D>().enabled = false;
                resim1.enabled = false; // Birinci resimi kapat
                resim2.gameObject.SetActive(true);

        }

    }

    public void dene()
    {
        Invoke("NextCanvas", 2f);

    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }
}
