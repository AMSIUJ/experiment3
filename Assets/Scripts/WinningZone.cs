using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class WinningZone : MonoBehaviour
{


	[SerializeField] private float timeDelay = 3.0f;
	[SerializeField] private  GameObject  Winning;
	[SerializeField] private string nextLevelToLoad = "Scene02";


	private IEnumerator loadNextLevel()
	{
		Winning.SetActive(true);
		yield return  new WaitForSeconds(timeDelay);
		
		SceneManager.LoadScene(nextLevelToLoad);
	}
	
	public void OnTriggerEnter2D(Collider2D collision) {
		
		if (collision.gameObject.CompareTag("Player"))
		{
			StartCoroutine(loadNextLevel());
		}
	}
}
