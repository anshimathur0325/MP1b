using UnityEngine;
public class addwater : MonoBehaviour
{
    public GameObject potSoil;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        end sc = FindAnyObjectByType<end>();
        risefall r = FindAnyObjectByType<risefall>();
    }
    void OnTriggerEnter(Collider s){
        print("hi2");
        if (s.CompareTag("water")){
            GameObject a = Instantiate(potSoil, transform.position, transform.rotation);
            Destroy(s.gameObject);
            Destroy(gameObject);
            risefall r = FindAnyObjectByType<risefall>();
            r.move(a);
            end sc = FindAnyObjectByType<end>();
            sc.Finish();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
