using UnityEngine;
using System.Collections;

public class BasicShotScript : MonoBehaviour {

	// 0 - Designer variables
	public int damage = 1;

	// Projectile damage player or enemies?
	public bool isEnemyShot = false;
	
	void Start()
	{
		// 1 - Limited time to live to avoid any leak
		Destroy(gameObject, 20); // 20sec
	}
}
