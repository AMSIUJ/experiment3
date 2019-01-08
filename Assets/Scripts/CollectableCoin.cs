using System;
using System.Collections;
using System.Collections.Generic;
using Tiled2Unity;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class CollectableCoin : MonoBehaviour
{

	public int coinValue = 1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnTriggerEnter2D(Collider2D collision) {
		
		Debug.Log("onTriggerEnter2D", gameObject);
		if (collision.tag == "Player")
		{
			FindObjectOfType<UIScore>().IncreaseScore(coinValue);
			
			GetComponent<Renderer>().enabled = false;
			GameObject.Destroy(gameObject);
			Destroy(this);
		}
	}
}
