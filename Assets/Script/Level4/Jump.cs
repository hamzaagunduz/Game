using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float ziplamaGucu = 10f;
    public int  carpisma = 0;

    public Canvas secondCanvas;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           carpisma++;
           collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up*ziplamaGucu,ForceMode2D.Impulse);
            if (carpisma ==4 )
            {
                secondCanvas.gameObject.SetActive(true);
            }
        }
    }

}
