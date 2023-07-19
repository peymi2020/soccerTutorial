using TMPro;
using UnityEngine;

public class ScoreBlueTeam : MonoBehaviour
{
	public int scoreBlue;
	public TextMeshProUGUI scoreB;

	void Update()
	{
		scoreB.text = scoreBlue.ToString();
	}

	public void AddScore()
	{
		scoreBlue += 1;
		scoreB.text = scoreBlue.ToString();
	}
}