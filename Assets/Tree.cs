using UnityEngine;

public class Tree : MonoBehaviour
{
    public float treeSpeed = 5.0f;
    public GameObject applePrefab;
    public GameObject branchPrefab;
    
    void Start()
    {
        Invoke("AppleDropper", 2.0f);
        Invoke("BranchDropper", 5.0f);
    }

    void Update()
    {
        transform.Translate(treeSpeed * Time.deltaTime, 0, 0);
    }

    void AppleDropper(){
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("AppleDropper", 1.0f);
    }
    void BranchDropper(){
        GameObject branch = Instantiate<GameObject>(branchPrefab);
        branch.transform.position = transform.position;
        Invoke("BranchDropper", 5.0f);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Bounds")
            treeSpeed *= -1.05f;
    }
}
