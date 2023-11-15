using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Select : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isTrueObject;
    public Canvas firstCanvas;
    public Canvas secondCanvas;

    public float rotationAmount = 30f; // A��sal hareket miktar� (derece)
    public float rotationSpeed = 1.3f; // A��sal h�z (derece/saat cinsinden)

    private float currentRotation = 0f; // G�ncel d�nme miktar�

    // Update is called once per frame
    void Update()
    {
        currentRotation += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Sin(currentRotation) * rotationAmount);

        // E�er belirli bir a��ya ula��ld�ysa, y�n� tersine �evir
        if (Mathf.Abs(currentRotation) >= 180f)
        {
            currentRotation = 0f;
        }
    }


    private void OnMouseDown()
    {
        if (isTrueObject)
        {
            Debug.Log("Do�ru se�im yapt�n!");
            firstCanvas.gameObject.SetActive(false); // FirstCanvas'� aktifle�tir
            secondCanvas.gameObject.SetActive(true); // SecondCanvas'� pasifle�tir
        }
        else
        {
            Debug.Log("Yanl�� se�im yapt�n!");
        }
    }
}
