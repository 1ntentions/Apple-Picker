using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bounds : MonoBehaviour
{
    public int score = 0;
    public int round;
    private List<GameObject> basketStack;
    public GameObject basketPrefab;

    void Start()
    {
        round = 1;
        basketStack = new List<GameObject>();
        for(int i = 0; i < 4; i++){
            GameObject basket = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = basket.transform.position;
            pos.y = -4.5f + i * .5f;
            basket.transform.position = pos;
            basketStack.Add(basket);
        }
    }
    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Apple"){
            round += 1;
            GameObject.Find("Round").GetComponent<Text>().text = "Round " + round.ToString();
            GameObject[] apples = GameObject.FindGameObjectsWithTag("Apple");
            int topBasket = basketStack.Count - 1;
            foreach(GameObject Apple in apples){
                Destroy(collision.gameObject);
            }
            if(topBasket > 0) {
                Destroy(basketStack[topBasket]);
                basketStack.RemoveAt(topBasket);
            }
            if(topBasket <= 0){
                SceneManager.LoadScene("GameOver");
            }
        }
        if(collision.gameObject.tag == "Branch"){
            Destroy(collision.gameObject);
        }
    }

    public void AddScore(){
        score += 1;
        GameObject.Find("Score").GetComponent<Text>().text = score.ToString();
    }

}
