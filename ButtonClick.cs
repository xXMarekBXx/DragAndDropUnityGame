using UnityEngine;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    TMP_Text txt;
    public void SetText(string text)
    {
        txt = transform.Find("Text (TMP)").GetComponent<TMP_Text>();
        Debug.Log(txt);
        txt.text = text;
    }
}


