using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public WeaponInfo weaponInfo;
	public bool isKI;
	public bool isPlayer;



	// Use this for initialization
	void Start () {

	}
	void CheckInput()
	{
		if(Input.GetButtonDown("Fire1"))
		{	

				Shooting();

		}	
	}



	void Shooting()
	{
		GameObject tmpBullet = (GameObject) Instantiate(weaponInfo.bullet,weaponInfo.bulletOut.position,weaponInfo.bulletOut.rotation);
		tmpBullet.GetComponent<Rigidbody2D>().AddForce(weaponInfo.bulletOut.right * weaponInfo.bulletForce);
	}
	// Update is called once per frame
	void FixedUpdate () {
		if(isPlayer)	
			CheckInput();
	}
	
}


