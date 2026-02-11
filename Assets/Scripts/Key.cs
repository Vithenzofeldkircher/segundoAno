using UnityEngine;

public class Key : MonoBehaviour, Itouchable
{
    public void Active()
    {
        //Aciona o sistema de inventario do player
        gameObject.SetActive(false);
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
