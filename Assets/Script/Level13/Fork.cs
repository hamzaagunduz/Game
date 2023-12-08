using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fork : MonoBehaviour
{
    public Tabak pasta;
    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    public bool catal = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alan�na giren nesnenin "dal" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Tabak")&& pasta.tabak==true)
        {
            resim1.enabled = false; // Birinci resimi kapat
            resim2.gameObject.SetActive(true);
            catal=true;
        }

    }
}
