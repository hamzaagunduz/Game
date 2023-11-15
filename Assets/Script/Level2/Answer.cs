using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public TextMeshProUGUI textMeshProTrue; // TextMeshPro nesnesi
    public TextMeshProUGUI textMeshProFalse; // TextMeshPro nesnesi

    public void Start()
    {
        textMeshProTrue.enabled = false;
        textMeshProFalse.enabled = false;
    }
    public void SetVisibilityTrue()
    {
        textMeshProTrue.enabled = true;
        textMeshProFalse.enabled = false;

    }
    public void SetVisibilityFalse()
    {
        textMeshProFalse.enabled = true;
    }

   
}
