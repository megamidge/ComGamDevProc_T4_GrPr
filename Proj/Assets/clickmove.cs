using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickmove : MonoBehaviour
{
    public GameObject[] waypoint;
    int current = 0;
    float rotspeed;
    public float speed;
    float wpradius = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void move()
    {
        
            if (Vector3.Distance(waypoint[current].transform.position, transform.position) < wpradius)
            {
                current++;
                if (current >= waypoint.Length)
                {
                    current = 0;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoint[current].transform.position, Time.deltaTime * speed);
        

    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
            move();
            
       // }
 
    
    }
}
