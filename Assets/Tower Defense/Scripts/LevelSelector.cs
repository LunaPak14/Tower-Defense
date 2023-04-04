using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;

    public Button[] levelsButtons;

    private void Start()
    {
        //uncomment line below to put level reached to 1
        //PlayerPrefs.SetInt("levelReached", 1);
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for (int i = 0; i < levelsButtons.Length; i++)
        {
            if (i + 1 > levelReached)
                levelsButtons[i].interactable = false;
        }
    }

    public void Select(string levelName)
    {
        fader.FadeTo(levelName);
    }
}
