using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    private Camera cam;
    private Vector3 basKonum;
    public float kontrolUzaklik = 5f;
    public Lamp lamp; // Lamp s�n�f�na eri�im i�in referans

    void Start()
    {
        cam = GameObject.Find("Camera").GetComponent<Camera>();
        basKonum = transform.position;
    }

    private void OnMouseDrag()
    {
        Vector3 position = cam.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;

        // Ba�lang�� konumundan belirli bir uzakl��a ula�t���nda kontrol et
        float uzaklik = Vector3.Distance(basKonum, transform.position);
        if (uzaklik >= kontrolUzaklik)
        {
            lamp.acik = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
