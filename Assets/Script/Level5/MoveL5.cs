using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveL5 : MonoBehaviour
{
    

    Camera cam;
    public GameObject cat;
    public Canvas secondCanvas;

    public float ziplamaGucu = 10f;
    Rigidbody2D rb;

    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = GameObject.Find("Camera").GetComponent<Camera>();
       
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            Vector3 t�klananPozisyon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            t�klananPozisyon.z = 0f; // Z eksenini s�f�rla (2D oyun oldu�u i�in)

            Vector2 ziplamaYonu = (t�klananPozisyon - transform.position).normalized;

            if (Input.GetMouseButtonDown(1))
            {
                // Sa� t�klama ise sola do�ru z�pla
                Zipla(-ziplamaYonu);
            }
            else
            {
                // Sol t�klama ise sa�a do�ru z�pla
                Zipla(ziplamaYonu);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            resim1.gameObject.SetActive(false); // Birinci resimi kapat
            resim2.gameObject.SetActive(true);
            cat.transform.position=transform.position;
            collision.gameObject.SetActive(false);
            Invoke("NextCanvas", 2f);

        }
    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }
    void Zipla(Vector2 yon)
    {
        if (rb != null)
        {
            rb.velocity = Vector2.zero; // H�z� s�f�rla
            rb.AddForce(yon * ziplamaGucu, ForceMode2D.Impulse);
        }
    }
}
