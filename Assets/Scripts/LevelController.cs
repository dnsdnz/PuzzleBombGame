using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    //public static LevelController Instance;

    public GameObject progressArea;
    public GameObject starArea;
    public Text levelNameText;
    public Text progressText;

    public GameObject playButton;
    public GameObject lockedSprite;

    public List<Image> stars;

    public bool isLevelActive;

    public int completedStarCount;
    private void Awake()
    {
      //  Instance = this;
    }

    private void Start()
    {
        
        //passive star color 3D3D3D
        //stars[0].sprite = activeStar.sprite;
    }

    public void ActiveButtonController()
    {
        if (isLevelActive)
        {
            playButton.SetActive(true);
            lockedSprite.SetActive(false);
        }
        else
        {
            playButton.SetActive(false);
            lockedSprite.SetActive(true);
        }
    }

    public void StarController()
    {
        if (isLevelActive && completedStarCount > 2)
        {
            starArea.SetActive(true);
        }
    }

    public void StartGame()
    {
        Debug.Log("Game started");
    }
}
