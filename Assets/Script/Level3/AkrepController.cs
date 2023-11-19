using UnityEngine;

public class AkrepController : MonoBehaviour
{
    public Transform akrep;
    private float minRotation = -180f; // Min d�nd�rme a��s�
    private float maxRotation = 180f; // Max d�nd�rme a��s�
    public float yesilAc�AltLimit = -120f;
    public float yesilAc�UstLimit = -100f;

    private bool isDragging = false;
    private Vector3 offset;

    public Canvas secondCanvas;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckForDragStart();
        }

        if (Input.GetMouseButton(0))
        {
            Dragging();
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }

    void CheckForDragStart()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Vector2.Distance(mousePosition, akrep.position) < 0.5f)
        {
            isDragging = true;
            offset = akrep.position - mousePosition;
        }
    }

    void Dragging()
    {
        if (isDragging)
        {
            MoveClockHand(offset);
        }
    }

    void MoveClockHand(Vector3 offset)
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        Vector3 newPosition = mousePosition + offset;

        float angle = Mathf.Atan2(newPosition.y - akrep.position.y, newPosition.x - akrep.position.x) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, minRotation, maxRotation);

        akrep.rotation = Quaternion.Euler(0, 0, angle);

        if (angle >= yesilAc�AltLimit && angle <= yesilAc�UstLimit)
        {
            secondCanvas.gameObject.SetActive(true);
        }
    }


}
