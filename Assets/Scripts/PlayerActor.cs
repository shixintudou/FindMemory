using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : BaseActor
{
    public float speed;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void StateRun()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if(x>0)
        {
            
        }
    }
}
