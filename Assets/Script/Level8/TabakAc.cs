using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabakAc : MonoBehaviour
{

    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    public bool acik = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alan�na giren nesnenin "dal" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Kepce"))
        {
            Debug.Log("colis girdi");

            
                resim1.enabled = false; // Birinci resimi kapat
                resim2.gameObject.SetActive(true);
                acik = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
