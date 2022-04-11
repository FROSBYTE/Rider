using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject win_canvas;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        win_canvas.SetActive(true);
        Time.timeScale = 0;
    }
}
