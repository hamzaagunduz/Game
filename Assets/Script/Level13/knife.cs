using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{
    public SpriteRenderer resim1;
    public SpriteRenderer resim2;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Pasta") )
        {
            Debug.Log("colis girdi");

            

                resim1.enabled = false; // Birinci resimi kapat
                resim1.GetComponent<Collider2D>().enabled = false;
                resim2.gameObject.SetActive(true);

        }

    }
}
