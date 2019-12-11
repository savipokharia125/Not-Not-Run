
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Management : MonoBehaviour
{
    public screenfader fader;

    public float delay = 0;
    bool check = false;
    public string nextlevel = "Scene/negation01";
    public int leveltounlock = 2;
    public GameObject CompleteLevelUI;
   
    public void CompleteLevel()
    {   
        // public string nextlevel = "level2";
        CompleteLevelUI.SetActive(true);
        PlayerPrefs.SetInt("levelreached", leveltounlock);
        fader.FadeTo(nextlevel);
    }
   
    public void EndGame()
    {
        if (check == false)
        {
            check = true;
            Debug.Log("GameOver");
             Invoke("Restart", delay);
          //  StartCoroutine(Restart());
        }
    }
      //public IEnumerator Restart ()
      public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
   
}

