using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    private Text uiText;

    private int score;

    [SerializeField] private int pointsToNetLevel;

    [SerializeField] private GameObject Winning;

    // Use this for initialization
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void IncreaseScore(int pointes)
    {
        score += pointes;
        if (score >= pointsToNetLevel)
        {
            Winning.SetActive(true);
            FindObjectOfType<PlayerController>().enabled = false;
        }

        uiText.text = "Score: " + score.ToString();
    }
}