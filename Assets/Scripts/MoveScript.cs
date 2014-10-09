using UnityEngine;
using System.Collections;

// Simply moves the current game object
public class MoveScript : MonoBehaviour
{
	// 0 - Designer variables
	// Projectile speed
	public Vector2 speed = new Vector2(10, 10);

	// Moving direction
	public Vector2 direction = new Vector2(0, -1);
	
	private Vector2 movement;
	
	void Update()
	{
		// 1 - Movement
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
	}
	
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}