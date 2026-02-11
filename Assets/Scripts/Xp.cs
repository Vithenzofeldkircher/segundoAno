using UnityEngine;

public class Xp : MonoBehaviour, IMagenetizablw, Itouchable
{
    private bool _Can_Move;
    private Transform _Origem;
    [SerializeField] private float _move_Rate = 2f;

    public void Magnetize(Transform target)
    {
        _Can_Move = true;
        _Origem = target;

        //gameObject.SetActive(false);
        Debug.Log("Item coletado");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        if (!_Can_Move)
            return;

        transform.position = Vector2.Lerp(transform.position, _Origem.position, _move_Rate/100);
    }
    public void Active()
    {
        Destroy(gameObject);
    }
}
