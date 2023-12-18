using UnityEngine;

public class KusOlustur : MonoBehaviour
{
    public GameObject kusPrefab; // Sahneye eklemi� oldu�unuz ku� prefab�
    public float olusturmaHizi = 2f; // Her bir ku�un olu�turulma h�z�
    private float olusturmaZamani = 0f;
    public Vector3 olusturmaKonumu = new Vector3(0f, 0f, 0f); // Olu�turulan ku�lar�n ba�lang�� konumu
    public float yokOlmaSuresi = 2f;

    public int av;

    public float ekYerCekimiGucu = 2f; // Yer �ekimi kuvvetini art�rmak i�in ek g��
    public Canvas secondCanvas;


    void Update()
    {
        // Belirli aral�klarla ku� olu�tur
        Ku�Olustur();
        yercekimi();

    }

    void Ku�Olustur()
    {
        olusturmaZamani += Time.deltaTime;

        // Belirli bir s�re ge�tikten sonra yeni bir ku� olu�tur
        if (olusturmaZamani >= 1f / olusturmaHizi)
        {
            // Ku� prefab�ndan yeni bir ku� olu�tur
            GameObject yeniKus = Instantiate(kusPrefab, olusturmaKonumu, Quaternion.identity);

            // Ku�un olu�turuldu�u yere rastgele bir y�kseklik ekleyerek daha do�al bir g�r�n�m elde et
            float rastgeleYukseklik = Random.Range(-1f, 1f);
            yeniKus.transform.Translate(Vector2.up * rastgeleYukseklik);

            Destroy(yeniKus, yokOlmaSuresi);
            // Olu�turma zaman�n� s�f�rla
            olusturmaZamani = 0f;
        }
    }

    void yercekimi()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // T�klanan noktadan bir ray �iz
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            // Ray'in bir objeyle �arp���p �arpmad���n� kontrol et
            if (hit.collider != null && hit.collider.CompareTag("Kus"))
            {
                // E�er �arp���lan obje bir kuysa, ek yer �ekimi uygula
                Rigidbody2D rb = hit.collider.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.gravityScale += ekYerCekimiGucu;
                    av++;
                    if (av == 4)
                    {
                        Invoke("Canvas", 2f);

                    }
                }
            }
        }
    }


    void Canvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }

}
