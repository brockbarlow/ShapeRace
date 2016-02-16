using UnityEngine;
using System.Collections;

public class P2 : MonoBehaviour
{
    private Rigidbody playerTwo;
    public float speed = 10;

    void Start()
    {
        playerTwo = GetComponent<Rigidbody>();
        playerTwo = GameObject.FindGameObjectWithTag("Player2").GetComponent<Rigidbody>();
    }

    void Update()
    {

            float h = Input.GetAxis("Horizontal2") * speed;
            float v = Input.GetAxis("Vertical2") * speed;

            gameObject.transform.position += transform.forward * (v * .02f);

            gameObject.transform.localEulerAngles = new Vector3(0f,
            transform.eulerAngles.y + ((h * speed) * Time.deltaTime), 0f);
            transform.Rotate(Vector3.right, (speed * h) * Time.deltaTime);
    }
}