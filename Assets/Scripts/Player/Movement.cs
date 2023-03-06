using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Y-Axis Roads Positions")]
    [SerializeField]
    private float y_roadSpace;
    [SerializeField]
    private float y_topLimit;
    [SerializeField]
    private float y_bottomLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < y_topLimit)
        {
            transform.Translate(0, y_roadSpace, 0);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > y_bottomLimit){
            transform.Translate(0, -y_roadSpace, 0);
        }
    }
}
