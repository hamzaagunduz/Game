using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHareket : MonoBehaviour
{
    public float hareketHizi = 2f;

    public GameObject kurþunPrefab;
    public Transform atýþNoktasý;

    public float kursunHizi = 15f;

    public bool kazan=true;
    void Update()
    {
        // Y ekseninde sürekli olarak 2 birim yukarý ve 2 birim aþaðý git
        transform.Translate(Vector3.up * hareketHizi * Time.deltaTime);

        // Eðer y ekseninde bir yere ulaþýrsa, ters yöne döndür
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
        // Kurþun prefabýný kullanarak yeni bir kurþun oluþtur
        GameObject yeniKurþun = Instantiate(kurþunPrefab, atýþNoktasý.position, Quaternion.identity);

        // Rigidbody2D bileþenini al ve belirli bir hýz ver (örneðin, saða doðru 10 birim/saniye)
        Rigidbody2D kurþunRigidbody = yeniKurþun.GetComponent<Rigidbody2D>();
        kurþunRigidbody.velocity = atýþNoktasý.right * kursunHizi;

        // Kurþunu belirli bir süre sonra yok et (örneðin, 2 saniye sonra)
        Destroy(yeniKurþun, 2f);
    }

}
