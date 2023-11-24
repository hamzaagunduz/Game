using UnityEngine;

public class ResmiSalla : MonoBehaviour
{
    [SerializeField]
    private int cikisSayisi = 0;

    public Renk renk;

    public SpriteRenderer resim1;
    public SpriteRenderer resim2;

    public Canvas secondCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Mix"))
        {
            cikisSayisi++;
            if(cikisSayisi == 4)
            { 
                resim1.enabled = false; // Birinci resimi kapat
                resim2.gameObject.SetActive(true);
                Invoke("NextCanvas", 2f);
            }
        }
    }

    void NextCanvas()
    {
        secondCanvas.gameObject.SetActive(true);
    }

}
