using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D body;

    private Vector2 _directionOfMove;

    private int _speedBall;
    private void Awake()
    {
        _speedBall = 3;
        body = GetComponent<Rigidbody2D>();
        SetStartDirectiont();
    }

    private void Update()
    {
        Move();
    }
    public void CalmState()
    {

    }
    public void ActiveState()
    {

    }
    private void Move()
    {
        body.velocity = _directionOfMove * _speedBall;
    }
    private void Stop()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("UpEdge"))
        {
            NewDirection(new Vector2(0,1));
            
            if (collision.gameObject.GetComponentInParent<Box>())
            {
                collision.gameObject.GetComponentInParent<Box>().BoxGetDamage();
            }
        }
        if (collision.gameObject.CompareTag("DownEdge"))
        {
            NewDirection(new Vector2(0, 1));
            if (collision.gameObject.GetComponentInParent<Box>())
            {
                collision.gameObject.GetComponentInParent<Box>().BoxGetDamage();
            }
        }
        if (collision.gameObject.CompareTag("LeftEdge"))
        {
            NewDirection(new Vector2(1, 0));
            if (collision.gameObject.GetComponentInParent<Box>())
            {
                collision.gameObject.GetComponentInParent<Box>().BoxGetDamage();
            }
        }
        if (collision.gameObject.CompareTag("RightEdge"))
        {
            NewDirection(new Vector2(1, 0));
            if (collision.gameObject.GetComponentInParent<Box>())
            {
                collision.gameObject.GetComponentInParent<Box>().BoxGetDamage();
            }
        }
    }
    private void SetStartDirectiont()
    {
        _directionOfMove.y = 1;
        _directionOfMove.x = Random.RandomRange(-1f, 1f);
    }
    private void NewDirection(Vector2 vec)
    {
        _directionOfMove = Vector2.Reflect(_directionOfMove, vec);
    }
}
