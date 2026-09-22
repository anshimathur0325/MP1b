using UnityEngine;
using UnityEngine.InputSystem;

public class water : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject droplets;
    public InputActionReference action;
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx)=>
        {
            for (int i =0; i< 10; i+=1) {
                Vector3 offset = new Vector3(Random.Range(-6f, 6f),10f,Random.Range(-6f, 6f));
                Instantiate(droplets,transform.position + offset,Quaternion.identity);
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
