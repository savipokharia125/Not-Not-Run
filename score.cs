
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Text uiHighScore;
    private int storenegation01;
    private int storenegation02;
    private int storenegation03;
    private int storebeginner;
    private int storecolourize01, storecolourize02, storecolourize03; 
    public Text scoreText;
    public Text paise;
    public int collects=0;
    Scene m_scene;
    public int sceneIndex;
    public float increase=0f;
    public Transform player;
    private int store;
    private int storecoin=0;

    public void Start()
    {
        store = (int)(player.transform.position.z + 743);
        m_scene = SceneManager.GetActiveScene();
        sceneIndex = m_scene.buildIndex;

        switch (sceneIndex)
        {
            case 1:
                uiHighScore.text = PlayerPrefs.GetInt("HighScoreBEG", 0).ToString();
                break;
            case 2:
                uiHighScore.text = PlayerPrefs.GetInt("HighScoreNEG01", 0).ToString();
                break;
            case 3:
                uiHighScore.text = PlayerPrefs.GetInt("HighScoreNEG02", 0).ToString();
                break;
            case 4:
                uiHighScore.text = PlayerPrefs.GetInt("HighScoreNEG03", 0).ToString();
                break;
            case 5:
                uiHighScore.text = PlayerPrefs.GetInt("HighScoreCOL01", 0).ToString();
                break;
            case 6:
                uiHighScore.text = PlayerPrefs.GetInt("HighScoreCOL02", 0).ToString();
                break;
            case 7:
                uiHighScore.text = PlayerPrefs.GetInt("HighScoreCOL03", 0).ToString();
                break;
            default:
                Debug.Log("No Index");
                break;
        }
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
    void Update()
    {
        store = (int)(player.transform.position.z+743);
       if(store<0)
            scoreText.text = "";
       else
        scoreText.text = ((int)((store+storecoin)/10)).ToString(); 
        storenegation01= (int)((store + storecoin) / 10);
        storenegation02 = (int)((store + storecoin) / 10);
        storenegation03 = (int)((store + storecoin) / 10);
        storecolourize01 = (int)((store + storecoin) / 10);
        storecolourize02 = (int)((store + storecoin) / 10);
        storecolourize03 =(int) ((store + storecoin) / 10);
        storebeginner = (int)((store + storecoin) / 10);
        //Debug.Log(scoreText.text+" "+storebeginner);
          
        if (storebeginner >= PlayerPrefs.GetInt("HighScoreBEG", 0)&&sceneIndex==1)
        {
            PlayerPrefs.SetInt("HighScoreBEG", storebeginner);
            uiHighScore.text = storebeginner.ToString();
        }

        if (storenegation01 >= PlayerPrefs.GetInt("HighScoreNEG01", 0) && sceneIndex == 2)
        {
            PlayerPrefs.SetInt("HighScoreNEG01", storenegation01);
            uiHighScore.text = storenegation01.ToString();
        }

        if (storenegation02 >= PlayerPrefs.GetInt("HighScoreNEG02", 0) && sceneIndex == 3)
        {
            PlayerPrefs.SetInt("HighScoreNEG02", storenegation02);
            uiHighScore.text = storenegation02.ToString();
        }

        if (storenegation03 >= PlayerPrefs.GetInt("HighScoreNEG03", 0) && sceneIndex == 4)
        {
            PlayerPrefs.SetInt("HighScoreNEG03", storenegation03);
            uiHighScore.text = storenegation03.ToString();
        }
        if (storecolourize01 >= PlayerPrefs.GetInt("HighScoreCOL01", 0) && sceneIndex == 5)
        {
            PlayerPrefs.SetInt("HighScoreCOL01", storecolourize01);
            uiHighScore.text = storecolourize01.ToString();
        }
        if (storenegation03 >= PlayerPrefs.GetInt("HighScoreCOL02", 0) && sceneIndex == 6)
        {
            PlayerPrefs.SetInt("HighScoreCOL02", storecolourize02);
            uiHighScore.text = storecolourize02.ToString();
        }
        if (storenegation03 >= PlayerPrefs.GetInt("HighScoreCOL03", 0) && sceneIndex == 7)
        {
            PlayerPrefs.SetInt("HighScoreCOL03", storecolourize03);
            uiHighScore.text = storecolourize03.ToString();
        }

    }
    public void Points ()
    {
      collects++;
            paise.text = collects.ToString();
        storecoin += 50;


    }
}