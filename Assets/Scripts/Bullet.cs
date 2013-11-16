using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float distroyTime;
	public float dmg;
	// Use this for initialization
	void Start () {
		Destroy(gameObject,distroyTime);
	}
	
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy")
			coll.gameObject.SendMessage("ApplyDamage", dmg);

		Destroy(gameObject);
	}
}
