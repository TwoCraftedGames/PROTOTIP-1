using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextBoxManager: MonoBehaviour
{
    public GameObject textBox;

    public Text theText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public PlayerMovement1 player;
    public bool isActive;

    public bool stopPlayerMovement;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement1>();
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));


        }

        if (endAtLine == 0)
        {
            endAtLine = textLines.Length -1;

        }

        if (isActive)
        {
            EnableTextBox();
        }
        
            else
        {
            DisableTextBox();
        }
        
    }

    private void Update()
    {

        theText.text = textLines[currentLine];
        if(!isActive)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;

        }

        if(currentLine > endAtLine)
        {
            DisableTextBox();
        }
    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);

        if(stopPlayerMovement)
        {
            player.canMove = false;
        }
    }

    public void DisableTextBox()
    {
        textBox.SetActive(false);

        player.canMove = true;
    }


    public void ReloadScript(TextAsset theText)
    {
        if(theText != null)
        {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));
        }


    }
}
