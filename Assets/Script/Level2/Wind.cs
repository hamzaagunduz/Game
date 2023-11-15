using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Wind : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform winds;
    public float moveDistance = 10f; // Taþýma mesafesi
    public float moveSpeed = 2f; // Taþýma hýzý

    private int moveDirection = 1;

    // Update is called once per frame
    void Update()
    {
        // Resmi sürekli olarak saða doðru hareket ettir
        // Nesneyi saða ve sola taþý
        winds.transform.Translate(Vector2.right * moveDirection * moveSpeed * Time.deltaTime);

        // Eðer belirli bir mesafeye ulaþýldýysa, taþýma yönünü tersine çevir
        if (Mathf.Abs(winds.transform.localPosition.x) >= moveDistance)
        {
            moveDirection = -moveDirection;
        }
    }
}
