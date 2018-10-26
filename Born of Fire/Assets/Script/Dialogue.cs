﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Cradle;
using Cradle.StoryFormats.Harlowe;

public class Dialogue : MonoBehaviour {

    public Story story;

    public GameObject textTemplate;
    public GameObject linkTemplate;
    public GameObject linebreakTemplate;

    public GameObject dialogueContainer;

    public ScrollRect consoleScroll;

    public float updateTime;

    int frameno;
    bool scrolling;

	// Use this for initialization
	void Start () {
        story.OnOutput += Display;

        this.story.Begin();
        frameno = 0;
        scrolling = false;
	}
	
	// Update is called once per frame
	void Update () {
        //consoleScroll.verticalNormalizedPosition = 0;
        frameno++;
	}

    public void Display(StoryOutput output) {
        GameObject UIchild = GenerateUIElement(output);
        AppendToConsole(UIchild);
    }
     
    public void DoLink(StoryLink link) {
        this.story.DoLink(link);
    }

    GameObject GenerateUIElement(StoryOutput output) {
        if(output is StoryText) {
            GameObject newTextElement = Instantiate(textTemplate);
            Text visibleText = newTextElement.GetComponent<Text>();
            visibleText.text = output.Text;

            return newTextElement;
        } else if(output is StoryLink) {
            GameObject newLinkElement = Instantiate(linkTemplate);
            Text visibleText = newLinkElement.GetComponent<Text>();
            visibleText.text = output.Text;

            LinkButton link = newLinkElement.GetComponent<LinkButton>();
            link.SetDelegate(() => {
                this.DoLink((StoryLink)output);
            });

            return newLinkElement;
        } /*else if(output is LineBreak) {
            GameObject newLinebreakElement = Instantiate(linebreakTemplate);

            return newLinebreakElement;
        }*/
        Debug.Log(output);
        return null;
    }

    void AppendToConsole(GameObject uiElement) {
        if(uiElement == null) {
            Debug.Log("STINKY");
            return;
        }
        uiElement.transform.SetParent(dialogueContainer.transform);
        //consoleScroll.verticalNormalizedPosition = 0;
        StartCoroutine(ScrollToBottom());
    }

    IEnumerator ScrollToBottom() {
        if (scrolling)
        {
            yield break;
        }
        scrolling = true;
        yield return new WaitForEndOfFrame();
        Canvas.ForceUpdateCanvases();
        float scrollDif = consoleScroll.verticalNormalizedPosition;

        for (int t = 0; t < updateTime; t++) {
            //Debug.Log(frameno + ", " + consoleScroll.verticalNormalizedPosition + ", " + t + ", " + (1 - ((float)(t) / updateTime)));
            //Canvas.ForceUpdateCanvases();
            consoleScroll.verticalNormalizedPosition = (Mathf.Cos((Mathf.PI * t) / (updateTime)) + 1) * scrollDif;
            yield return null;
        }
        consoleScroll.verticalNormalizedPosition = 0;
        scrolling = false;
    }
}