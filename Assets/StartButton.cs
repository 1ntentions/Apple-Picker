using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    public void StartGame(){
        SceneManager.LoadScene("MainScene");
    }
}
