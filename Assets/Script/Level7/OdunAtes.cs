using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdunAtes : MonoBehaviour
{
    public bool fire=false;
   


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Trigger alan�na giren nesnenin "dal" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Dal"))
        {
            Debug.Log("girdi");
            fire = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Trigger alan�na giren nesnenin "dal" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Dal"))
        {
            Debug.Log("cikti");

            fire = false;
        }

    }

}
