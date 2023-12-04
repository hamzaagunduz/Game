using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golet : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    public bool su = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Kova"))
        {
            Debug.Log("colis girdi");


            resim1.enabled = false; // Birinci resimi kapat
            resim2.gameObject.SetActive(true);
            su = true;
        }

    }
}
