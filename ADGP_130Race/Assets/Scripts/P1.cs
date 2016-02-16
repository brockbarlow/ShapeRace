using UnityEngine;
using System.Collections;

public class P1 : MonoBehaviour
{
    private Rigidbody playerOne;
    public float speed = 10;

    void Start()
    {
        playerOne = GetComponent<Rigidbody>();
        playerOne = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }


    void Update()
    {

        float h = Input.GetAxis("Horizontal") * speed;
        float v = Input.GetAxis("Vertical") * speed;

        gameObject.transform.position += transform.forward * (v * .02f);

        gameObject.transform.localEulerAngles = new Vector3(0f,
        transform.eulerAngles.y + ((h * speed) * Time.deltaTime), 0f);
        transform.Rotate(Vector3.right, (speed * h) * Time.deltaTime);
    }
}