using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHareket : MonoBehaviour
{
    public float hareketHizi = 2f;

    public GameObject kur�unPrefab;
    public Transform at��Noktas�;

    public float kursunHizi = 15f;

    public bool kazan=true;
    void Update()
    {
        // Y ekseninde s�rekli olarak 2 birim yukar� ve 2 birim a�a�� git
        transform.Translate(Vector3.up * hareketHizi * Time.deltaTime);

        // E�er y ekseninde bir yere ula��rsa, ters y�ne d�nd�r
        if (transform.position.y >= 3f || transform.position.y <= -3f)
        {
            hareketHizi *= -1;
        }

        if (Input.GetMouseButtonDown(0)&kazan==true)
        {
            AtisYap();
        }


    }

    void AtisYap()
    {
        // Kur�un prefab�n� kullanarak yeni bir kur�un olu�tur
        GameObject yeniKur�un = Instantiate(kur�unPrefab, at��Noktas�.position, Quaternion.identity);

        // Rigidbody2D bile�enini al ve belirli bir h�z ver (�rne�in, sa�a do�ru 10 birim/saniye)
        Rigidbody2D kur�unRigidbody = yeniKur�un.GetComponent<Rigidbody2D>();
        kur�unRigidbody.velocity = at��Noktas�.right * kursunHizi;

        // Kur�unu belirli bir s�re sonra yok et (�rne�in, 2 saniye sonra)
        Destroy(yeniKur�un, 2f);
    }

}
