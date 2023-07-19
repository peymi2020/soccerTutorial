using UnityEngine;

public class BallIntraction : MonoBehaviour
{
	public ScoreBlueTeam scoreBlueTeam;
	public ScoreRedTeam scoreRedTeam;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Redteam"))
		{
			scoreBlueTeam.AddScore();
		}
		else if (other.CompareTag("Blueteam"))
		{
			scoreRedTeam.AddScore();
		}
	}
}