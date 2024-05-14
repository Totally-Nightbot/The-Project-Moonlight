using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityModifier : MonoBehaviour
   

{
    //public variable for gravity modifier
    public int Gravity = -15;
    
    // Start is called before the first frame update
    void Start()
    {
        //Puts the gravity to a higher number
        Physics.gravity = new Vector3(0, Gravity, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
