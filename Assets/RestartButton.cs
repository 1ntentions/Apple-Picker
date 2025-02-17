using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void RestartGame(){
        SceneManager.LoadScene("MainScene");
    }
}
