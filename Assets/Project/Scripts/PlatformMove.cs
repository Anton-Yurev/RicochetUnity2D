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
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3( 1 * Time.deltaTime * _speedPlatform,0,0));
        }
    }
    public void UpSpeed()
    {
        _speedPlatform += 2;
    }
}
