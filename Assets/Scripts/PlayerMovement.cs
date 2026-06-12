using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 32f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move vehicle forward
        //transform.Translate(0, 0, speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
