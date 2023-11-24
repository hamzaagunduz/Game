using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renk : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public bool degisti=false;
    void Start()
    {

        // SpriteRenderer bileþenini al
        spriteRenderer = GetComponent<SpriteRenderer>();

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            spriteRenderer.color = new Color(0.6f, 0.4f, 0.2f); // Kahverengi renk
            degisti= true;

        }
    }
    
}
