using UnityEngine;

public class KusOlustur : MonoBehaviour
{
    public GameObject kusPrefab; // Sahneye eklemiþ olduðunuz kuþ prefabý
    public float olusturmaHizi = 2f; // Her bir kuþun oluþturulma hýzý
    private float olusturmaZamani = 0f;
    public Vector3 olusturmaKonumu = new Vector3(0f, 0f, 0f); // Oluþturulan kuþlarýn baþlangýç konumu
    public float yokOlmaSuresi = 2f;

    public int av;

    public float ekYerCekimiGucu = 2f; // Yer çekimi kuvvetini artýrmak için ek güç
    public Canvas secondCanvas;


    void Update()
    {
        // Belirli aralýklarla kuþ oluþtur
        KuþOlustur();
        yercekimi();

    }

    void KuþOlustur()
    {
        olusturmaZamani += Time.deltaTime;

        // Belirli bir süre geçtikten sonra yeni bir kuþ oluþtur
        if (olusturmaZamani >= 1f / olusturmaHizi)
        {
            // Kuþ prefabýndan yeni bir kuþ oluþtur
            GameObject yeniKus = Instantiate(kusPrefab, olusturmaKonumu, Quaternion.identity);

            // Kuþun oluþturulduðu yere rastgele bir yükseklik ekleyerek daha doðal bir görünüm elde et
            float rastgeleYukseklik = Random.Range(-1f, 1f);
            yeniKus.transform.Translate(Vector2.up * rastgeleYukseklik);

            Destroy(yeniKus, yokOlmaSuresi);
            // Oluþturma zamanýný sýfýrla
            olusturmaZamani = 0f;
        }
    }

    void yercekimi()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Týklanan noktadan bir ray çiz
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            // Ray'in bir objeyle çarpýþýp çarpmadýðýný kontrol et
            if (hit.collider != null && hit.collider.CompareTag("Kus"))
            {
                // Eðer çarpýþýlan obje bir kuysa, ek yer çekimi uygula
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
