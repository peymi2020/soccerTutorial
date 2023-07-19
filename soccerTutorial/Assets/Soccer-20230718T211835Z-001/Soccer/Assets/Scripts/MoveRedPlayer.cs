using UnityEngine;

namespace Test
{
	public class MoveRedPlayer : MonoBehaviour
	{
		public Rigidbody rb;
		
		public float speed = 10f;
		
		private Vector2 moveInput;
		
		void Update()
		{
			float xInput = Input.GetAxis("Horizontal");
			float yInput = Input.GetAxis("Vertical");

			moveInput = new Vector2(xInput, yInput);
		}

		private void FixedUpdate()
		{
			Vector3 deltaPosition = new Vector3(moveInput.x * speed, 0f, moveInput.y * speed) * Time.fixedDeltaTime;

			rb.MovePosition(transform.position + deltaPosition);
		}
	}
}