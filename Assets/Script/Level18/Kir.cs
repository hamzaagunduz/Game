using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kir : MonoBehaviour
{
    public int giris=0;
    public bool tam=false;

    public Brush firca;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alan�na giren nesnenin "dal" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("firca")& collision != null)
        {
            giris++;
            if (giris == 3)
            {
                Destroy(gameObject);
                firca.giris++;
                if (firca.giris == 12)
                {
                    firca.NextCanvas();
                }
            }

        }

    }
}
