using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour
{
    public SpriteRenderer resim1;
    public SpriteRenderer resim2;
    public SpriteRenderer resim3;

    public bool gir;

    public GameObject rocket;

    public float hareketHizi = 3f; // Nesnenin yukar� do�ru hareket h�z�

    public Canvas secondCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alan�na giren nesnenin "dal" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Match"))
        {
            Debug.Log("colis girdi");



            resim1.enabled = false; // Birinci resimi kapat
            resim2.gameObject.SetActive(true);
            gir = true;

        }

        if (collision.gameObject.CompareTag("Rocket")&gir==true)
        {
            Debug.Log("colis girdi");



            resim3.gameObject.SetActive(true);
            Invoke("NextCanvas", 4f);

            StartCoroutine(YukariHareketCoroutine());



        }
           

    }


        IEnumerator YukariHareketCoroutine()
          {
            while (true)
            {
                // Yukar� do�ru hareket i�in Vector3.up'i kullan
                rocket.transform.Translate(Vector3.up * hareketHizi * Time.deltaTime);
                yield return null; // Bir frame bekleyin
            }
          }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }
}
