using System.Transactions;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
public class PlayerManager : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpForce = 3f;

    private bool gameCompleted = false;
    private bool isGrounded = false;
    
    [SerializeField] private GameObject ScoreUi;

    private Rigidbody rb;
    private Renderer _renderer;


    private float horizontal; 
    private float vertical;
    public int Score = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        _renderer = GetComponent<Renderer>();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        horizontal = Input.GetAxisRaw("Horizontal"); 
        vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    private void Movement()
    {
        float horizontal= Input.GetAxis("Horizontal");
        float vertical= Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        rb.AddForce(direction * moveSpeed);

    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
        Debug.Log("Zýpladýn!");
    }



    private void FixedUpdate()
    {
        
        Movement();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("+Coin"))
        {
            Score += 10;
            Destroy(other.gameObject);
            Debug.Log("+Coin Score" + Score);

        }

        else if (other.CompareTag("-Coin"))
        {
            Score -= 5;
            Destroy(other.gameObject);
            Debug.Log("-Coin Score" + Score);
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Yerdesin!");
        }
    }


}

