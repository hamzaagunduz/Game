using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perdecol : MonoBehaviour
{
    // Start is called before the first frame update
    public bool perde = false;

    public Degnek deg;

    public Canvas secondCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Trigger alan�na giren nesnenin "Perde" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Perde"))
        {
            Debug.Log("girdi");
            perde = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Trigger alan�na giren nesnenin "Perde" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Perde"))
        {
            Debug.Log("cikti");

            perde = false;
        }

        if (deg.cikisSayisi >= 3& perde==false)
        {
            Invoke("NextCanvas", 2f);
        }
            

    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }
}

