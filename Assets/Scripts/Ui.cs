using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{

  public void Play()
   {
        SceneManager.LoadScene(1);
   }
   public void Quit()
   {
        Application.Quit();
   }
   public void Restart()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
   }
   public void Menu()
   {
        SceneManager.LoadScene(0);
   }
   public void Nextlevel()
   {
        SceneManager.LoadScene(2);
   }
}
