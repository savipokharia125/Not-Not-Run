using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AddCollision : MonoBehaviour
{
    public GameObject uipressD;
    public GameObject uiletsBegin;
    public GameObject uipressA;
    public GameObject uiRight;
    public GameObject uiLeft;
    public GameObject uiCenter;
    public GameObject uiNotRight;
    public GameObject uiNotLeft;
    public GameObject uiNotCenter;
    public GameObject uiNotNotNotRight;
    public GameObject uiNotNotNotLeft;
    public GameObject uiNotNotNotCenter;
    public GameObject uinotnotRight;
    public GameObject uinotnotLeft;
    public GameObject uinotnotCenter;
    public GameObject uiblue;
    public GameObject uiyellow;
    public GameObject uired;
    public GameObject uinotblue;
    public GameObject uinotyellow;
    public GameObject uinotred;
    public GameObject uinotnotblue;
    public GameObject uinotnotyellow;
    public GameObject uinotnotred;
    public GameObject uibluered;
    public GameObject uiyellowblu;
    public GameObject uiredyel;
    public GameObject uiblueyel;
    public GameObject uiyellowred;
    public GameObject uiredblu;
    public GameObject uinotbluered;
    public GameObject uinotyellowblu;
    public GameObject uinotredyel;
    public GameObject uinotblueyel;
    public GameObject uinotyellowred;
    public GameObject uinotredblu;
    public GameObject uiWelcome;
    public GameObject uiBonus;
    public GameObject uiplus;
    public GameObject uiLeftRed;
    public GameObject uicenterBlue;
    public int late=5;
    public force f;
    
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("OnCollisionEnter()");
        if (col.collider.tag=="obstacle")
        {
           
           f.enabled = false;
            
            FindObjectOfType<Management>().EndGame();
            
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            Debug.Log("coin");
            Destroy(other.gameObject);
            FindObjectOfType<AudioManagement>().Play("coins");
            FindObjectOfType<score>().Points();
            //StartCoroutine(ShowMessage(0));
        }
        if(other.tag=="Start")
        {
            Debug.Log("Welllcomeeeee");
            uiWelcome.SetActive(true);
        }
        else
            uiWelcome.SetActive(false);
 

        if (other.tag=="end")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if(other.tag=="illusion")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "bonus")
        {
            StartCoroutine(ShowMessage(1));
        }

        if (other.tag == "pressA")
        {
            StartCoroutine(ShowMessage(-2));
        }
        if (other.tag == "pressB")
        {
            StartCoroutine(ShowMessage(-1));
        }
        if (other.tag=="right")
        {
            StartCoroutine(ShowMessage(2));
        }

        if (other.tag == "left")
        {
            StartCoroutine(ShowMessage(3));
        }

        if (other.tag == "center")
        {
            StartCoroutine(ShowMessage(4));
        }
       
        if (other.tag == "notRight")
        {
            StartCoroutine(ShowMessage(5));
        }

        if (other.tag == "notLeft")
        {
            StartCoroutine(ShowMessage(6));
        }
       
        if (other.tag == "notCenter")
        {
            StartCoroutine(ShowMessage(7));
        }

        if (other.tag == "notnotright")
        {
            StartCoroutine(ShowMessage(8));
        }
       
        if (other.tag == "notnotleft")
        {
            StartCoroutine(ShowMessage(9));
        }
     
        if (other.tag == "notnotcenter")
        {
            StartCoroutine(ShowMessage(10));
        }
      
        if (other.tag == "blue")
        {
            StartCoroutine(ShowMessage(11));
        }
       
        if (other.tag == "red")
        {
            StartCoroutine(ShowMessage(12));
        }
       
        if (other.tag == "yellow")
        {
            StartCoroutine(ShowMessage(13));
        }
        
        if (other.tag == "blueyel")
        {
            StartCoroutine(ShowMessage(14));
        }
    
        if (other.tag == "bluered")
        {
            StartCoroutine(ShowMessage(15));
        }
       
        if (other.tag == "yellowred")
        {
            StartCoroutine(ShowMessage(16));
        }
       
        if (other.tag == "yellowblu")
        {
            StartCoroutine(ShowMessage(17));
        }
      
        if (other.tag == "redblu")
        {
            StartCoroutine(ShowMessage(18));
        }
       
        if (other.tag == "redyel")
        {
            StartCoroutine(ShowMessage(19));
        }

        if (other.tag == "notblue")
        {
            StartCoroutine(ShowMessage(20));
        }

        if (other.tag == "notred")
        {
            StartCoroutine(ShowMessage(21));
        }

        if (other.tag == "notyellow")
        {
            StartCoroutine(ShowMessage(22));
        }

        if (other.tag == "notblueyel")
        {
            StartCoroutine(ShowMessage(23));
        }

        if (other.tag == "notbluered")
        {
            StartCoroutine(ShowMessage(24));
        }

        if (other.tag == "notyellowred")
        {
            StartCoroutine(ShowMessage(25));
        }

        if (other.tag == "notyellowblu")
        {
            StartCoroutine(ShowMessage(26));
        }

        if (other.tag == "notredblu")
        {
            StartCoroutine(ShowMessage(27));
        }

        if (other.tag == "notredyel")
        {
            StartCoroutine(ShowMessage(28));
        }

        if (other.tag == "notnotnotryt")
        {
            StartCoroutine(ShowMessage(29));
        }

        if (other.tag == "notnotnotleft")
        {
            StartCoroutine(ShowMessage(30));
        }

        if (other.tag == "notnotnotcenter")
        {
            StartCoroutine(ShowMessage(31));
        }
        if (other.tag == "leftred")
        {
            StartCoroutine(ShowMessage(32));
        }
        if (other.tag == "centerBlue")
        {
            StartCoroutine(ShowMessage(33));
        }
        if (other.tag == "lets")
        {
            StartCoroutine(ShowMessage(34));
        }
    }
    IEnumerator ShowMessage(int check)
    {
        switch (check)
        {
            case -2:
                {
                    uipressA.SetActive(true);
                    yield return new WaitForSeconds(1);
                    uipressA.SetActive(false);
                }
                break;
            case -1:
                {
                    uipressD.SetActive(true);
                    yield return new WaitForSeconds(1);
                    uipressD.SetActive(false);
                }
                break;
            case 0:
                {
                    uiplus.SetActive(true);
                    yield return new WaitForSeconds(1);
                    uiplus.SetActive(false);
                }
                break;
            case 1:
                { uiBonus.SetActive(true);

                    FindObjectOfType<AudioManagement>().Play("bonus");
                    yield return new WaitForSeconds(3);
                    uiBonus.SetActive(false);
                }
                break;
            case 2:
                {
                    uiRight.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiRight.SetActive(false);
                }
                break;
            case 3:
                {
                    uiLeft.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiLeft.SetActive(false);
                }
                break;
            case 4:
                {
                    uiCenter.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiCenter.SetActive(false);
                }
                break;
            case 5:
                {
                    uiNotRight.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiNotRight.SetActive(false);
                }
                break;
            case 6:
                {
                    uiNotLeft.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiNotLeft.SetActive(false);
                }
                break;
            case 7:
                {
                    uiNotCenter.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiNotCenter.SetActive(false);
                }
                break;
            case 8:
                {
                    uinotnotRight.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotnotRight.SetActive(false);
                }
                break;
            case 9:
                {
                    uinotnotLeft.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotnotLeft.SetActive(false);
                }
                break;
            case 10:
                {
                    uinotnotCenter.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotnotCenter.SetActive(false);
                }
                break;
            case 11:
                {
                    uiblue.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiblue.SetActive(false);
                }
                break;
            case 12:
                {
                    uired.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uired.SetActive(false);
                }
                break;
            case 13:
                {
                    uiyellow.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiyellow.SetActive(false);
                }
                break;
            case 14:
                {
                    uiblueyel.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiblueyel.SetActive(false);
                }
                break;
            case 15:
                {
                    uibluered.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uibluered.SetActive(false);
                }
                break;
            case 16:
                {
                    uiyellowred.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiyellowred.SetActive(false);
                }
                break;
            case 17:
                {
                    uiyellowblu.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiyellowblu.SetActive(false);
                }
                break;
            case 18:
                {
                    uiredblu.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiredblu.SetActive(false);
                }
                break;
            case 19:
                {
                    uiredyel.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiredyel.SetActive(false);
                }
                break;
            case 20:
                {
                    uinotblue.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotblue.SetActive(false);
                }
                break;
            case 21:
                {
                    uinotred.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotred.SetActive(false);
                }
                break;
            case 22:
                {
                    uinotyellow.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotyellow.SetActive(false);
                }
                break;
            case 23:
                {
                    uinotblueyel.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotblueyel.SetActive(false);
                }
                break;
            case 24:
                {
                    uinotbluered.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotbluered.SetActive(false);
                }
                break;
            case 25:
                {
                    uinotyellowred.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotyellowred.SetActive(false);
                }
                break;
            case 26:
                {
                    uinotyellowblu.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotyellowblu.SetActive(false);
                }
                break;
            case 27:
                {
                    uinotredblu.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotredblu.SetActive(false);
                }
                break;
            case 28:
                {
                    uinotredyel.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uinotredyel.SetActive(false);
                }
                break;
            case 29:
                {
                    uiNotNotNotRight.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiNotNotNotRight.SetActive(false);
                }
                break;
            case 30:
                {
                    uiNotNotNotLeft.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiNotNotNotLeft.SetActive(false);
                }
                break;
            case 31:
                {
                    uiNotNotNotCenter.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiNotNotNotCenter.SetActive(false);
                }
                break;
            case 32:
                {
                    uiLeftRed.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uiLeftRed.SetActive(false);
                }
                break;
            case 33:
                {
                    uicenterBlue.SetActive(true);
                    yield return new WaitForSeconds(late);
                    uicenterBlue.SetActive(false);
                }
                break;
            case 34:
                {
                    uiletsBegin.SetActive(true);
                    yield return new WaitForSeconds(2);
                    uiletsBegin.SetActive(false);
                }
                break;
            default:
                Debug.Log("Finish");
                break;
        }
    }
}
