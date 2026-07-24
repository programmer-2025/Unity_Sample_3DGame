using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        const float speed = 1.0f;
        transform.position += speed * transform.forward * Time.deltaTime;
    }
}
