using UnityEngine;

namespace Test
{
	public class MoveBluePlayer : MonoBehaviour
	{
		public Rigidbody rb;
		
		public float speed = 10f;
		
		private Vector2 moveInput;
		
		void Update()
		{
			float xInput = 0f;
			float yInput = 0f;

			if (Input.GetKey(KeyCode.L))
			{
				xInput = 1f;
			}
			else if (Input.GetKey(KeyCode.J))
			{
				xInput = -1f;
			}
			
			if (Input.GetKey(KeyCode.I))
			{
				yInput = 1f;
			}
			else if (Input.GetKey(KeyCode.K))
			{
				yInput = -1f;
			}

			moveInput = new Vector2(xInput, yInput);
		}

		private void FixedUpdate()
		{
			Vector3 deltaPosition = new Vector3(moveInput.x * speed, 0f, moveInput.y * speed) * Time.fixedDeltaTime;

			rb.MovePosition(transform.position + deltaPosition);
		}
	}
}