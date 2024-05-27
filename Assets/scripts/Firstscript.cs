using UnityEngine;
using System;

namespace Test
{
    public class Firstscript : MonoBehaviour
    {
        /*
         //bool true - false
         //double 
         //decimal 11.1
         //short long
        */
        public float speed;

        // Start is called before the first frame update
        public void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            int newSpeed = 5;
            print(" Car move " + newSpeed);
            Debug.Log(" Car move" + System.Math.PI);
            transform.Translate(speed * Time.deltaTime, 0, 0);
            
        }

        Vector2 GetPosition()
        {
            return transform.position;
        }

        int GetResult(string text)
        {
            // Parsing 
            return 2 + 2; 
        }

        bool IsInSight()
        {
            return true;
        }

    }
}