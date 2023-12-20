using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hareketHizi = 2f;
    public SpriteRenderer[] taslar;
    private int currentIndex = 0;
    public GunHareket gun;

    public Canvas secondCanvas;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * hareketHizi * Time.deltaTime);

        // Eðer y ekseninde bir yere ulaþýrsa, ters yöne döndür
        if (transform.position.y >= 3f || transform.position.y <= -3f)
        {
            hareketHizi *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Kus"))
        {

            taslar[currentIndex].enabled = false;
            currentIndex++;
            if (currentIndex == 3)
            {
                gun.kazan = false;
                Invoke("Canvas", 2f);
            }
        }
    }

    void Canvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }

}
