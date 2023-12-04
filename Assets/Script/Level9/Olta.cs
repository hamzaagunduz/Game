using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olta : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("colis");

        // Trigger alanýna giren nesnenin "dal" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Mik"))
        {

            //collision.transform.position = transform.position;
            collision.transform.position = GetComponent<Collider2D>().transform.position;
            collision.transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y - 1f, collision.transform.position.z);
        }

    }
}
