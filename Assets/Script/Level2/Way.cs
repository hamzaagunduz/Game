using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way : MonoBehaviour
{
 

    public float hareketHizi = 5f; // Nesnenin hareket hýzý
    public float tekrarUzaklik = 10f; // Nesnenin tekrar baþa dönme mesafesi

    void Update()
    {
        // Nesneyi ters yönde ileri doðru hareket ettir
        transform.Translate(Vector2.left * hareketHizi * Time.deltaTime);

        // Eðer belirli bir mesafeye ulaþýldýysa, nesneyi baþa döndür
        if (transform.position.x <= -tekrarUzaklik)
        {
            transform.position = new Vector2(tekrarUzaklik, transform.position.y);
        }
    }
}
