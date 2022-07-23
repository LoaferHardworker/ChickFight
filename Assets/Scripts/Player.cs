using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed = 5;
	private Rigidbody2D _rb;
	
	private void Start()
	{
		_rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		Move();
	}

	void Move()
	{
		var factor = 0f;
		
		if (Input.GetKey(KeyCode.D)) factor++;
		if (Input.GetKey(KeyCode.A)) factor--;
		
		_rb.velocity = new Vector2(speed * factor, _rb.velocity.y);
	}
}
