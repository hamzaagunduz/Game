using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level1Devam : MonoBehaviour
{
    public Canvas firstCanvas;
    public Canvas secondCanvas;
    public int puzzle = 0;
    public void devamEt()
    {
        firstCanvas.gameObject.SetActive(false); // FirstCanvas'ý aktifleþtir
        secondCanvas.gameObject.SetActive(true); // SecondCanvas'ý pasifleþtir
        Debug.Log("sad");
    }

    // Update is called once per frame
    public void dene()
    {
        SceneManager.LoadScene("Level2");

    }
 
}
