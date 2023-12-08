using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Couple : MonoBehaviour
{
    // Start is called before the first frame update

    public Fork catal;
    public SpriteRenderer resim2;
    public Canvas secondCanvas;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Fork") && catal.catal == true)
        {
            resim2.gameObject.SetActive(true);
            Invoke("NextCanvas", 2f);

        }

    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }

}
