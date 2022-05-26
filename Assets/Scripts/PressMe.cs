using UnityEngine;
using UnityEngine.UI;
public class PressMe : MonoBehaviour
{
    int n;
    public Text myText;
    public void OnButtonPress()
    {
        n++;
        myText.text = "Te adoyo mucho";
    }
}
