using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]

public class Plataform_Movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _horizontal;
    [SerializeField] private float _Speed = 5;
    [SerializeField] private float _jump_Force = 250;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }
    private void FixedUpdate()
    {
        _rb.linearVelocity = new Vector2(_horizontal * _Speed, _rb.linearVelocity.y);
    }
    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(new Vector2(0, _jump_Force));
        }
    }

    private void OnValidate()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

}
