using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    // Start is called before the first frame update
    public Bag bag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Emp"))
        {
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject);
            bag.para++;
            if (bag.para == 5)
            {
                bag.dene();

            }

        }
    }

   

}
