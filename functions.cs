
using UnityEngine;
using UnityEngine.UI;

public class Functions : MonoBehaviour
{
    public Text r;
    public Text l;
    public Text c;

    public void Left()
    {
        l.text = "Left".ToString();
    }
    public void Right()
    {
        r.text = "Right".ToString();
    }

    public void Center()
    {
        c.text = "Center".ToString();
    }
}
