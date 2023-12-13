using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{


    public float speed;
    private LineRenderer _lineRenderer;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }
    // Update is called once per frame
    void Update()
    {

       if(_lineRenderer.positionCount!=0) { 
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 tempveck = new Vector3(touchPosition.x, touchPosition.y, 0);
            tempveck = tempveck.normalized * (speed * Time.deltaTime);

            transform.position += tempveck;
        }


    }
}
