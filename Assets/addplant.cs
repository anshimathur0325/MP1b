using UnityEngine;

public class addplant : MonoBehaviour
{
    public GameObject potSoil;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider s){
        print("hi");
        if (s.CompareTag("seed")){
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
