using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Duvar : MonoBehaviour
{
    public TextMeshProUGUI textMeshProNesnesi;

    public int any=0;
    public Canvas secondCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Kus"))
        {

            any++;
            textMeshProNesnesi.text = any.ToString();
            if (any == 50)
            {
                Invoke("Canvas", 2f);

                textMeshProNesnesi.text = "";
            }

        }
    }


    void Canvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }

}
