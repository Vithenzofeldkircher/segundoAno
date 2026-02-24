using UnityEngine;

public class Animation_Player : MonoBehaviour
{
    private Animator _Animation;
    private SpriteRenderer _spriteRenderer;
    private Psyhic_Player _physicalPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _Animation = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _physicalPlayer = GetComponentInParent<Psyhic_Player>();


        Game_Controller.instance.On_Player_Move_Begin.AddListener(() => 
        {
            _Animation.SetBool("isRunnig", true);
        
        });

        Game_Controller.instance.On_Player_Move_Begin.AddListener(() =>
        {
            _Animation.SetBool("isRunnig", true);

        });
    }

    // Update is called once per frame
    void Update()
    {
        if(_physicalPlayer.Horizontal == 0)
        {
            return;
        }
        _spriteRenderer.flipX = _physicalPlayer.Horizontal < 0;
    }
}
