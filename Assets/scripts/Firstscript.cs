using System;
using UnityEngine;

public class Firstscript : MonoBehaviour {
    

    public float speed;
    
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        print ( " Car move " );
        transform.Translate (speed, 0,0 );
    }
    
}
