using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mizrak : MonoBehaviour
{
    public GameObject Prefab; // Sahneye eklemiþ olduðunuz kuþ prefabý
    public float olusturmaHizi = 2f; // Her bir kuþun oluþturulma hýzý
    private float olusturmaZamani = 0f;
    public Vector3 olusturmaKonumu = new Vector3(0f, 0f, 0f); // Oluþturulan kuþlarýn baþlangýç konumu
    public float yokOlmaSuresi = 2f;




    void Update()
    {
        // Belirli aralýklarla kuþ oluþtur
        KuþOlustur();

    }

    void KuþOlustur()
    {
        olusturmaZamani += Time.deltaTime;

        // Belirli bir süre geçtikten sonra yeni bir kuþ oluþtur
        if (olusturmaZamani >= 1f / olusturmaHizi)
        {
            // Kuþ prefabýndan yeni bir kuþ oluþtur
            GameObject Mizrak = Instantiate(Prefab, olusturmaKonumu, Quaternion.identity);
            Mizrak.transform.rotation = Quaternion.Euler(0f, 0f, -90f);

            // Kuþun oluþturulduðu yere rastgele bir yükseklik ekleyerek daha doðal bir görünüm elde et
            float rastgeleYukseklik = Random.Range(-3f, 3f);
            Mizrak.transform.Translate(Vector2.up * rastgeleYukseklik);

            Destroy(Mizrak, yokOlmaSuresi);
            // Oluþturma zamanýný sýfýrla
            olusturmaZamani = 0f;
        }
    }
}
