using UnityEngine;
using UnityEngine.SceneManagement;

public class Basket : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 rawMouse = Input.mousePosition;
        Vector3 convertedMouse = Camera.main.ScreenToWorldPoint(rawMouse);
        Vector3 pos = transform.position;
        pos.x = convertedMouse.x;
        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Apple"){
            Destroy(collision.gameObject);
            GameObject.Find("Boundaries").GetComponent<Bounds>().AddScore();
        }
        if(collision.gameObject.tag == "Branch"){
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
