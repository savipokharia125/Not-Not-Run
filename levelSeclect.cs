using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelSeclect : MonoBehaviour
{
    public screenfader fader;
    public Button[] levelButtons;

    public void Start()
    {
        int levelreached = PlayerPrefs.GetInt("levelreached", 1);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if(i + 1 > levelreached)
            levelButtons[i].interactable = true;
        }
        
    }

    public void Select (string levelName)
    {
        fader.FadeTo(levelName);
    }
}
