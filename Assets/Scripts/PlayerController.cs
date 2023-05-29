using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public int speedTurning = 20;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0f, 0f, -speedTurning * Time.deltaTime, ForceMode.VelocityChange);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0f, 0f, speedTurning * Time.deltaTime, ForceMode.VelocityChange);

        }
        /*float movement = Input.GetAxis("Horizontal");
        rb.AddForce(0f, 0f, -speedTurning * movement * Time.deltaTime, ForceMode.VelocityChange);*/
    }
    private void FixedUpdate()
    {
        rb.AddForce(-speed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) 
        {
            this.enabled = false;
            FindObjectOfType<GameOver>().endGame();
        }
    }
}
