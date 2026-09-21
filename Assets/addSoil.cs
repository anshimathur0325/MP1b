using UnityEngine;

public class addSoil : MonoBehaviour
{
    public GameObject potSoil;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider s){
        print("hello");
        if (s.CompareTag("soil")){
            Instantiate(potSoil, transform.position, transform.rotation);
            
            Destroy(s.gameObject);
            Destroy(gameObject);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
