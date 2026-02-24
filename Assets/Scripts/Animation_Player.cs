using UnityEngine;

public class Animation_Player : MonoBehaviour
{
    private Animation _Animation;
    private SpriteRenderer _spriteRenderer;
    private Psyhic_Player _physicalPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _Animation = GetComponent<Animation>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _physicalPlayer = GetComponentInParent<Psyhic_Player>();
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
