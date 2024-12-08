using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 20f;           //This float will tell me how fast the  bullet is when it is shot
    public float bulletDuration = 2f;   //This float will set a time limit before the bullet disappears from the scene

    private float bulletTimer;          //This float will countdown the time set in bulletDuration

    public int damage = 40;             //This tells me the amount of damage a single bullet can do

    //public int damage2 = 100;         //This tells me the amount of damage a single bullet can do

    public Rigidbody2D rb;              //Get the rigidbody component so we can use in this script

    void Start()
    {
        bulletTimer = bulletDuration;

        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        //Check when bullets are deleted from the scene
        bulletTimer -= Time.deltaTime;
        if (bulletTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
        EnemyScript enemy0 = collision.GetComponent<EnemyScript>();
        EnemyScript2 enemy1 = collision.GetComponent<EnemyScript2>();
        EnemyBossScript enemy2 = collision.GetComponent<EnemyBossScript>();

        if (enemy0 != null)
        {
            enemy0.TakeDamage(damage);
        }

        if (enemy1 != null)
        {
            enemy1.TakeDamage(damage);
        }

        else if (enemy2 != null)
        {
            enemy2.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

    /*
    [SerializeField] private float speed;
    private float direction;
    private bool hit;

    private BoxCollider2D boxCollider;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (hit) return;
        float movementSpeed = speed * Time.deltaTime * direction;
        transform.Translate(movementSpeed, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
        boxCollider.enabled = false;
    }

    public void SetDirection(float _direction)
    {
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
    */
}
