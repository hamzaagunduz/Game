using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way : MonoBehaviour
{
 

    public float hareketHizi = 5f; // Nesnenin hareket h�z�
    public float tekrarUzaklik = 10f; // Nesnenin tekrar ba�a d�nme mesafesi

    void Update()
    {
        // Nesneyi ters y�nde ileri do�ru hareket ettir
        transform.Translate(Vector2.left * hareketHizi * Time.deltaTime);

        // E�er belirli bir mesafeye ula��ld�ysa, nesneyi ba�a d�nd�r
        if (transform.position.x <= -tekrarUzaklik)
        {
            transform.position = new Vector2(tekrarUzaklik, transform.position.y);
        }
    }
}
