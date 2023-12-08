using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Answer : MonoBehaviour
{
    public TextMeshProUGUI textMeshProTrue; // TextMeshPro nesnesi
    public TextMeshProUGUI textMeshProFalse; // TextMeshPro nesnesi

    public void Start()
    {
        textMeshProTrue.enabled = false;
        textMeshProFalse.enabled = false;
    }
    public void SetVisibilityTrue()
    {
        textMeshProTrue.enabled = true;
        textMeshProFalse.enabled = false;
        SonrakiSeviyeyeGec();

    }
    public void SetVisibilityFalse()
    {
        textMeshProFalse.enabled = true;
    }




    // Örneðin, bir düðmeye týklandýðýnda bu fonksiyonu çaðýrabilirsiniz
    public void SonrakiSeviyeyeGec()
    {
        // Mevcut seviyenin ismini al (örneðin, bu fonksiyon bir düðmeye týklandýðýnda)
        string mevcutSeviye = SceneManager.GetActiveScene().name;

        // Yeni seviyeye geçiþ yap
        YeniSeviyeYukle(mevcutSeviye);
    }
    void YeniSeviyeYukle(string mevcutSeviye)
    {
        // Mevcut seviye ismini al
        int mevcutSeviyeNumarasi = int.Parse(mevcutSeviye.Substring("Level".Length));

        // Bir sonraki seviyenin ismini oluþtur
        int yeniSeviyeNumarasi = mevcutSeviyeNumarasi + 1;

        string yeniSeviye = "Level" + yeniSeviyeNumarasi;


        // Yeni seviyeyi yükle
        SceneManager.LoadScene(yeniSeviye);
    }



}
