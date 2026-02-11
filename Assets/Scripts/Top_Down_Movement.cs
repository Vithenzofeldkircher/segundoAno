using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class Top_Down_Movement : MonoBehaviour
{

    

    //Utilizado para determinar a velocidade do Player.
    [Header("Movement")]
    public float speed = 2.0f;
    
   
    private Vector2 _movement;
    private Rigidbody2D _rb;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }
    //fazsdfa
    // Update is called once per frame
    void Update()
    {
        _movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // atribui as teclas de movimento do player...
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = _movement * speed; //Atribuindo o controle á fisíca...
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Itouchable target))
        {
            target.Active();
        }
    }

}