using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Wind : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform winds;
    public float moveDistance = 10f; // Ta��ma mesafesi
    public float moveSpeed = 2f; // Ta��ma h�z�

    private int moveDirection = 1;

    // Update is called once per frame
    void Update()
    {
        // Resmi s�rekli olarak sa�a do�ru hareket ettir
        // Nesneyi sa�a ve sola ta��
        winds.transform.Translate(Vector2.right * moveDirection * moveSpeed * Time.deltaTime);

        // E�er belirli bir mesafeye ula��ld�ysa, ta��ma y�n�n� tersine �evir
        if (Mathf.Abs(winds.transform.localPosition.x) >= moveDistance)
        {
            moveDirection = -moveDirection;
        }
    }
}
