using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text textText;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartText (Text text)
    {
        Debug.Log("Showing Message");

        sentences.Clear();

        foreach (string sentence in text.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndText();
            return;
        }

        string sentence = sentences.Dequeue();
        textText.text = sentence;
    }

    void EndText()
    {
        Debug.Log ("End of Message")
    }

}
