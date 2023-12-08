using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tas : MonoBehaviour
{
    public SpriteRenderer[] taslar;

    public string hedefTag = "ResimTag"; // Týklama hedefi olan game objelerin tag'i

    private int currentIndex = 0;

    public GameObject karak;

    public Canvas secondCanvas;

    public SpriteRenderer resim2;


    void Start()
    {
        //for (int i = 0; i < taslar.Length; i++)
        //{
        //    taslar[i].gameObject.GetComponent<Collider2D>().enabled = false;
        //}
        taslar[currentIndex].gameObject.GetComponent<Collider2D>().enabled = true;
    }

    void Update()
    {
        // Mouse týklamasý algýlama
        if (Input.GetMouseButtonDown(0))
        {
            // Týklama yapýlan pozisyonu al
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // Eðer týklama bir game objesine denk geliyorsa ve bu obje belirtilen tag'e sahipse devam et
            if (hit.collider != null && hit.collider.CompareTag(hedefTag))
            {
                karak.transform.position = hit.collider.transform.position;
                if(currentIndex< taslar.Length-1)
                { 
                    taslar[currentIndex+1].gameObject.GetComponent<Collider2D>().enabled=true;
                    taslar[currentIndex].gameObject.GetComponent<Collider2D>().enabled = false;
                    currentIndex++;
                    
                }
                else
                {
                    resim2.gameObject.SetActive(true);
                    Invoke("NextCanvas", 2f);

                }
            }
        }
    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }


}
