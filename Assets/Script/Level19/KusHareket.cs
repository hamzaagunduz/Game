using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusHareket : MonoBehaviour
{
    // Start is called before the first frame update
  

    public float hareketHizi = 5f;
    private Rigidbody2D rb;

    public float ekYerCekimiGucu = 2f; // Yer çekimi kuvvetini artýrmak için ek güç

  


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Baþlangýçta saða hareket et
        HareketEt(Vector2.right);
    }

    void Update()
    {
        // Kuþun hareketi
        HareketEt(Vector2.right);
    }

    void HareketEt(Vector2 yon)
    {
        // Kuþun belirli bir yönde hareket etmesi
        rb.velocity = yon * hareketHizi;
    }

   

    

}
