
using UnityEngine;
using UnityEngine.SceneManagement;
public class RESUME : MonoBehaviour
{
    public static bool GameISPaused = false;
   // public GameObject pauseUI;
    public 
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
          //  if(GameISPaused)
           // {
                Resume();
          //  }
            
        }
    }

    public void Resume()
    {
        
        //Time.timeScale = 1f;
        SceneManager.LoadScene(0);
      /*  GameISPaused = false;
        pauseUI.SetActive(false);*/
    }
   /*public void Pause ()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        GameISPaused = true;
    }
    public void GameMenu()
    {
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene(0);
    }

    public void GameQuit()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
    */
}
