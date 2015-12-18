using UnityEngine;
using System.Collections;

public class Skeleton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector2.right * 1f * Time.deltaTime );
	}
}
