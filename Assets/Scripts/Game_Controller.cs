using UnityEngine;
using UnityEngine.Events;

public class Game_Controller : MonoBehaviour
{
    public static Game_Controller instance;
    [SerializeField] private bool _Is_Game_Runiig;
    [Space]
    [Header("Player Events")]
    public UnityEvent On_Player_Move_Begin;
    public UnityEvent On_Player_Move_End;
    [Space]
    [Header("Game Events")]
    public UnityEvent On_Game_Begin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(_Is_Game_Runiig)
            On_Game_Begin.Invoke();
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        instance = this;
    }

}
