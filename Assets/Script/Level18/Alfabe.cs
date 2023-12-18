using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alfabe : MonoBehaviour
{

    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    public GameObject kir;

    // Update is called once per frame
    void Update()
    {
        // Mouse sol tuþa basýldýðýnda
        if (Input.GetMouseButtonDown(0))
        {
            // Fare pozisyonunu 2D uzayda al
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Týklama pozisyonuna bir Collider2D var mý diye kontrol et
            Collider2D hitCollider = Physics2D.OverlapPoint(clickPosition);

            // Eðer bir Collider2D varsa ve bu script'e ait objeyle çakýþýyorsa
            if (hitCollider != null && hitCollider.gameObject == gameObject&&hitCollider.gameObject.CompareTag("Alfabe"))
            {
                resim1.enabled = false; // Birinci resimi kapat
                resim2.gameObject.SetActive(true);
                kir.SetActive(true);
            }
        }
    }


}
