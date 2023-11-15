using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Select : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isTrueObject;
    public Canvas firstCanvas;
    public Canvas secondCanvas;

    public float rotationAmount = 30f; // Açýsal hareket miktarý (derece)
    public float rotationSpeed = 1.3f; // Açýsal hýz (derece/saat cinsinden)

    private float currentRotation = 0f; // Güncel dönme miktarý

    // Update is called once per frame
    void Update()
    {
        currentRotation += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Sin(currentRotation) * rotationAmount);

        // Eðer belirli bir açýya ulaþýldýysa, yönü tersine çevir
        if (Mathf.Abs(currentRotation) >= 180f)
        {
            currentRotation = 0f;
        }
    }


    private void OnMouseDown()
    {
        if (isTrueObject)
        {
            Debug.Log("Doðru seçim yaptýn!");
            firstCanvas.gameObject.SetActive(false); // FirstCanvas'ý aktifleþtir
            secondCanvas.gameObject.SetActive(true); // SecondCanvas'ý pasifleþtir
        }
        else
        {
            Debug.Log("Yanlýþ seçim yaptýn!");
        }
    }
}
