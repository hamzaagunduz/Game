using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mizrak : MonoBehaviour
{
    public GameObject Prefab; // Sahneye eklemi� oldu�unuz ku� prefab�
    public float olusturmaHizi = 2f; // Her bir ku�un olu�turulma h�z�
    private float olusturmaZamani = 0f;
    public Vector3 olusturmaKonumu = new Vector3(0f, 0f, 0f); // Olu�turulan ku�lar�n ba�lang�� konumu
    public float yokOlmaSuresi = 2f;




    void Update()
    {
        // Belirli aral�klarla ku� olu�tur
        Ku�Olustur();

    }

    void Ku�Olustur()
    {
        olusturmaZamani += Time.deltaTime;

        // Belirli bir s�re ge�tikten sonra yeni bir ku� olu�tur
        if (olusturmaZamani >= 1f / olusturmaHizi)
        {
            // Ku� prefab�ndan yeni bir ku� olu�tur
            GameObject Mizrak = Instantiate(Prefab, olusturmaKonumu, Quaternion.identity);
            Mizrak.transform.rotation = Quaternion.Euler(0f, 0f, -90f);

            // Ku�un olu�turuldu�u yere rastgele bir y�kseklik ekleyerek daha do�al bir g�r�n�m elde et
            float rastgeleYukseklik = Random.Range(-3f, 3f);
            Mizrak.transform.Translate(Vector2.up * rastgeleYukseklik);

            Destroy(Mizrak, yokOlmaSuresi);
            // Olu�turma zaman�n� s�f�rla
            olusturmaZamani = 0f;
        }
    }
}
