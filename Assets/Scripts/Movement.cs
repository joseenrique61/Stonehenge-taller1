using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed;
	public float sensitivityX;
	public float sensitivityY;

	private Rigidbody rb;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update()
	{
		transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x + Input.GetAxisRaw("Mouse Y") * sensitivityY * -1, transform.rotation.eulerAngles.y + Input.GetAxisRaw("Mouse X") * sensitivityX, transform.rotation.eulerAngles.z));

		 rb.AddForce((Input.GetAxisRaw("Horizontal") * transform.right + Input.GetAxisRaw("Vertical") * transform.forward) * speed);
	}
}
