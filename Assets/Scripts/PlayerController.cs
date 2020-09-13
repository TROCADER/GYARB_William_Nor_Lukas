using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D playerRb2D;
    public float gravityModifier;
    public float jumpForce;

    public float downForce;
    public bool gameOver = false;

    void Start()
    {
        playerRb2D = GetComponent<Rigidbody2D>();
        Physics2D.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if ((playerRb2D.velocity.y == 0f && Input.GetKeyDown(KeyCode.Space)) | (playerRb2D.velocity.y == 0f && Input.GetKeyDown(KeyCode.UpArrow)))
        {
            playerRb2D.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerRb2D.AddForce(Vector3.down * downForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameOver = true;
            Debug.Log("Game over");
        }
    }
}
