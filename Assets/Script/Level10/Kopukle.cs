using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kopukle : MonoBehaviour
{
    public SpriteRenderer resim2;

    public bool samp = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Kopuk")&samp==false)
        {
             resim2.gameObject.SetActive(true);
             samp = true;  
        }

    }
}
