using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject tutorialPanel;

    private void Start()
    {
        sceneStart();
    }


    private void sceneStart()
    {
        Time.timeScale = 0; /// EXTRA  //freezes the time
        startPanel.SetActive(true);
    }

    public void startButton()
    {
        startPanel.SetActive(false);
        tutorialPanel.SetActive(true);

    }


    public void startMatch()
    {
        Time.timeScale = 1; /// EXTRA make it run again
        tutorialPanel.SetActive(false);

    }











}
