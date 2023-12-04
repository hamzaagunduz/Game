using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelector : MonoBehaviour
{
    public int level;
    public TextMeshProUGUI text;
    void Start()
    {
        text.text=level.ToString();
    }

   public void OpenScene()
    {
        SceneManager.LoadScene("Level"+level.ToString());
    }
}
