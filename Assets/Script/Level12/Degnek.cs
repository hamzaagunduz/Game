using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degnek : MonoBehaviour
{
    // Start is called before the first frame update
    public int cikisSayisi = 0;


    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    public Perdecol ates;

    //public Canvas secondCanvas;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Dal2") && ates.perde == true)
        {
            Debug.Log("colis girdi");

            cikisSayisi++;
            if (cikisSayisi == 3)
            {

                resim1.enabled = false; // Birinci resimi kapat
                resim2.gameObject.SetActive(true);
                //Invoke("NextCanvas", 2f);

            }
        }

    }
}
