using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabak : MonoBehaviour
{
    public bool tabak = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alan�na giren nesnenin "dal" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Tabak"))
        {
            tabak= true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Trigger alan�na giren nesnenin "Perde" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Tabak"))
        {
            tabak = false;
        }


    }


}
