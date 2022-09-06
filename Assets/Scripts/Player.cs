using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
