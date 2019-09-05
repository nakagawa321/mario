using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_create : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject[] star = new GameObject[3];
    public GameObject Congrats;
    public GameObject Disappointment;
    private int star_value;
    private enum STAR_VALUE {
        NULL,
        ONE,
        TWO,
        THREE,
    }

    // Start is called before the first frame update
    void Start()
    {
        this.star_value = CollisionManager.getStar_vlue(); // CollisionManagerからスターの数取得

        // 星をprefaabから子として作成
        var parent = Canvas.transform;
        switch (this.star_value) {
            case (int)STAR_VALUE.ONE:
                Destroy(star[1].gameObject);
                Destroy(star[2].gameObject);
                Destroy(Disappointment.gameObject);
                break;
            case (int)STAR_VALUE.TWO:
                Destroy(star[2].gameObject);
                Destroy(Disappointment.gameObject);
                break;
            case (int)STAR_VALUE.THREE:
                Destroy(Disappointment.gameObject);
                break;
            default:
                Destroy(star[0].gameObject);
                Destroy(star[1].gameObject);
                Destroy(star[2].gameObject);
                Destroy(Congrats.gameObject);
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
