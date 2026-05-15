using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    private int _speedPlatform;
    public void Start()
    {
        _speedPlatform = 5;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * _speedPlatform);
            //if (transform.position.x < -8)
            //{
            //    transform.position = new Vector2(-8, transform.position.y);
            //}
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3( 1 * Time.deltaTime * _speedPlatform,0,0));
            //if (transform.position.x > 8)
            //{
            //    transform.position = new Vector2(8, transform.position.y);
            //}
        }
    }
}
