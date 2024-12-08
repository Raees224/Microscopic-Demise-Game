using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    //[SerializeField] private float speed;
    //[SerializeField] private float jump;

    public float speed; //Declare speed variable for moving left and right
    public float jump; //Declare Jump variable for jumping

    private Rigidbody2D body; //Get the rigidbody component so we can use in this script
    private float hzInput; //Declare hzInput variable to get the horizontal component
    private bool m_FacingRight = true; //This boolean will allow my player to turn whenever it moves in different direction

    private bool isGrounded;            //This boolean detects if the player is on the ground layer 
    private bool isGrounded2;           //This boolean detects if the player is on the enemy layer 

    public Transform groundCheck;       //Get the groundcheck component from unity so we can use in this script
    public float checkRadius;           //Determine how big the radius is of the circle for groundCheck is
    
    public LayerMask whatIsGround;      //Check if the player is standing on the ground layer
    public LayerMask whatIsGround2;      //Check if the player is standing on the ground layer

    private int extraJumps;              //Gives the player additional jumps
    public int extraJumpsValue;          //Allows the player to change the amount of additional jumps in unity
                                         
    private void Start()                 
    {
        extraJumps = extraJumpsValue;
        body = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround2);
        isGrounded2 = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        hzInput = Input.GetAxis("Horizontal"); //Horizontal is a built in unity function that allow you to use the left and right arrow keys for a purpose e.g. move a player on screen. These controls are changeable

        body.velocity = new Vector2(hzInput * speed, body.velocity.y); // The rigidbody will move along the x axis

        //Flips the player when he moves left or right
        //Right Direction
        if (hzInput > 0.01f && !m_FacingRight)
        {
            transform.localScale = Vector3.one;
            Turn();
        }

        //Left Direction
        else if (hzInput < -0.01f && m_FacingRight)
        {
            //transform.localScale = new Vector3(-1, 1, 1);
            Turn();
        }
    }

    private void Update()
    {
        if(isGrounded == true) 
        {
            extraJumps = extraJumpsValue;
        }

        if (isGrounded2 == true)
        {
            extraJumps = extraJumpsValue;
        }

        if (Input.GetKey(KeyCode.Space) && extraJumps > 0)
        {
            body.velocity = Vector2.up * jump;
            extraJumps--;
            
        }

        else if (Input.GetKey(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
           //body.velocity = Vector2.up * jump;
        }
    }

    private void Turn()
    {
        m_FacingRight = !m_FacingRight;

        transform.Rotate(0, 180f, 0f);
    }

    //private bool isGroundedTwo()
    //{
    //    return false;
    //}

    //public bool canAttack()
    //{
    //    return horizontalInput == 0 && isGrounded();
    //}
}
