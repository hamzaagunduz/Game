using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public Duvar duvar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alan�na giren nesnenin "dal" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Kus"))
        {
            duvar.any--;
            duvar.textMeshProNesnesi.text = duvar.any.ToString();
            Destroy(collision.gameObject);


        }
    }

}
