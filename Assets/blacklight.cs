using UnityEngine;
using UnityEngine.InputSystem;
public class blacklight : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject box;
    public InputActionReference action;
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx)=>
        {        
            Destroy(box);

        };
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }
}
