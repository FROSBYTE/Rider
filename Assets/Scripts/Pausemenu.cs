using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour
{
    public static bool Gamepaused = false;
    public GameObject pausemenuui;
    private void Start()
    {
       pausemenuui.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Gamepaused == true)
            {
                resume();
            }
            else
            {
                pause();
            }
        }    
    }
    public void resume()
    {
        pausemenuui.SetActive(false);
        Time.timeScale = 1f;
        Gamepaused = false;
    }
    public void pause()
    {
        StartCoroutine("pausemenucoroutine");
    }

    IEnumerator pausemenucoroutine()
    {
        pausemenuui.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 0f;
        Gamepaused = true;
       
    }
}
