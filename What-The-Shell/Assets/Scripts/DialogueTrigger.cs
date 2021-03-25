using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;

    public void TriggerDialogue()
    {

        Debug.Log(GameObject.FindWithTag("NewText").activeSelf);

        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
