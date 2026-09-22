using UnityEngine;

public class addplant : MonoBehaviour
{
    public GameObject potSoil;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        risefall r = FindAnyObjectByType<risefall>();
    }
    void OnTriggerEnter(Collider s){
        print("hi");
        if (s.CompareTag("seed")){
            GameObject a = Instantiate(potSoil, transform.position, transform.rotation);
            
            Destroy(s.gameObject);
            Destroy(gameObject);
            risefall r = FindAnyObjectByType<risefall>();
            r.move(a);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
