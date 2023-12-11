using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esles : MonoBehaviour
{

    Camera cam;
    GameObject[] golgeler;
    Vector2 basKonum;
    public Devam dev;

    public Canvas secondCanvas;

    void Start()
    {
        cam = GameObject.Find("Camera").GetComponent<Camera>();
        golgeler = GameObject.FindGameObjectsWithTag("Cevap");
        basKonum = transform.position;
    }

    private void OnMouseDrag()
    {
        Vector3 position = cam.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject gol in golgeler)
            {
                if (gameObject.name == gol.name)
                {
                    float dist = Vector3.Distance(gol.transform.position, transform.position);
                    if (dist <= 1)
                    {
                        transform.position = gol.transform.position;
                        Destroy(this);
                        dev.puzzle++;
                        if (dev.puzzle == 9)
                        {
                            dev.dene();

                        }
                    }
                    else
                    {
                        transform.position = basKonum;
                    }

                }

            }
        }

  

    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }

}
