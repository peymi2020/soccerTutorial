using TMPro;
using UnityEngine;

public class ScoreRedTeam : MonoBehaviour
{
	public int scoreRed;
	public TextMeshProUGUI scoreR;

	void Update()
	{
		scoreR.text = scoreRed.ToString();
	}

	public void AddScore()
	{
		scoreRed += 1;
		scoreR.text = scoreRed.ToString();
	}
}