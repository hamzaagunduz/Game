using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KusHareket : MonoBehaviour
{
    // Start is called before the first frame update
  

    public float hareketHizi = 5f;
    private Rigidbody2D rb;

    public float ekYerCekimiGucu = 2f; // Yer �ekimi kuvvetini art�rmak i�in ek g��

  


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Ba�lang��ta sa�a hareket et
        HareketEt(Vector2.right);
    }

    void Update()
    {
        // Ku�un hareketi
        HareketEt(Vector2.right);
    }

    void HareketEt(Vector2 yon)
    {
        // Ku�un belirli bir y�nde hareket etmesi
        rb.velocity = yon * hareketHizi;
    }

   

    

}
