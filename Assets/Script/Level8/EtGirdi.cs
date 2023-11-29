using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtGirdi : MonoBehaviour
{
    public TabakAc tabak;

    public Canvas secondCanvas;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Et")&&tabak.acik==true)
        {
            Debug.Log("colisdas girdi");

            Invoke("NextCanvas", 2f);


        }
    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }
}
