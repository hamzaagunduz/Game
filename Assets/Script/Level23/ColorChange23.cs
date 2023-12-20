using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange23 : MonoBehaviour
{
    private bool gre=false;
    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    public Canvas secondCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Kus"))
        {
            Material nesneMateryali = GetComponent<Renderer>().material;
            nesneMateryali.color = Color.green;
            gre=true;

        }
        if (collision.gameObject.CompareTag("Emp")&gre==true)
        {
            Destroy(collision.gameObject);
            resim1.enabled = false; // Birinci resimi kapat
            resim2.enabled=true;
            Invoke("Canvas", 2f);

        }
    }

    void Canvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }

}
