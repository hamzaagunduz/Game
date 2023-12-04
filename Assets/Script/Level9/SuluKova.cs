using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuluKova : MonoBehaviour
{
     public Golet kova;
    public Canvas secondCanvas;


    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");
        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Player") && kova.su== true)
        {
            resim1.enabled = false; // Birinci resimi kapat
            resim2.gameObject.SetActive(true);
            Invoke("NextCanvas", 2f);
        }

    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }
}
