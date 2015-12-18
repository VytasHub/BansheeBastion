using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour 
{
	Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector2.right * 2f * Time.deltaTime );
	}
	void OnTriggerEnter(Collider other)
	{
		anim.SetTrigger ("touched");

	}
}
