using UnityEngine;

public class Magnetic_Area : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<IMagenetizablw>(out var magenetizablw))
        {
            magenetizablw.Magnetize(transform);
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
