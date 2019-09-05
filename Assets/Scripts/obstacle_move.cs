using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_move : MonoBehaviour
{
    private float under_limit = 0.4f; // 針の下の限界
    private float upper_limit = 4.0f; // 針の上の限界
    
    // 針が上か下かの列挙型
    private enum MOVE_TYPE
    {
        MOVE_DOWN, // 下
        MOVE_UP,   // 上
    }
    private MOVE_TYPE type = MOVE_TYPE.MOVE_DOWN;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 針の上下の動き
        switch (type) {
            case MOVE_TYPE.MOVE_DOWN:
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.01f, this.transform.position.z);
                break;

            case MOVE_TYPE.MOVE_UP:
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.01f, this.transform.position.z);
                break;

        }

        // 針の上下の動き判断
        if(this.transform.position.y < under_limit)
        {
            type = MOVE_TYPE.MOVE_UP;
        }
        if (this.transform.position.y > upper_limit)
        {
            type = MOVE_TYPE.MOVE_DOWN;
        }


    }



}

