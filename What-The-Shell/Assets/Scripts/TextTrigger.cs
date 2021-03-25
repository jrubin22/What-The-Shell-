using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public Text text;

    public void TriggerText ()
    {
        FindObjectOfType<TextManager>().StartText(text)
    }
}
