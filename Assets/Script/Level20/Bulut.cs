using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulut : MonoBehaviour
{
    public Planet bitki;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alan�na giren nesnenin "dal" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Emp"))
        {
            bitki.gun= true;
            bitki.sayi++;
            bitki.resim1.enabled= false;
            bitki.resim2.enabled= true;
            Destroy(gameObject);
           

        }
    }
}
