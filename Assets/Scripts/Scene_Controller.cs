using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.SetActiveScene(gameObject.scene);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (SceneManager.sceneCount == 1)
                return;

            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        }
    }


}
