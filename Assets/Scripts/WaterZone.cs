using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class WaterZone : MonoBehaviour
{
	
	[SerializeField] private float timeDelay = 2.0f;
	[SerializeField] private GameObject gameOver;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator restartScene()
	{
		gameOver.SetActive(true);
		
		yield return new WaitForSeconds(timeDelay);
		
		SceneManager.LoadScene("Scene01");
	}
	
	public void OnTriggerEnter2D(Collider2D collision) {
		
		if (collision.gameObject.CompareTag("Player"))
		{
			StartCoroutine(restartScene());
		}
	}
}
