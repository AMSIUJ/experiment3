using System.Collections;
using System.Collections.Generic;
using Tiled2Unity;
using UnityEngine;

public class CammeraFollow : MonoBehaviour
{

	private Vector2 valocity;
	
	public float smoothTimeY;
	public float smoothTimeX;
	
	public GameObject player;
	
	void Start ()
	{
		
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void FixedUpdate ()
	{
		float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref valocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref valocity.y, smoothTimeY);
		
		transform.position = new Vector3(posX,posY,transform.position.z);
	}
}
