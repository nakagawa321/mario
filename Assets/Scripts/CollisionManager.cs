using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    public GameObject[] life = new GameObject[3];
    public static int heart_value = 3;

    // getter
    public static int getStar_vlue()
    {
        return heart_value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ゴールの当たり判定処理
    public void goal_hit_test_process()
    {
        SceneManager.LoadScene("Finish");
    }

    // 針の当たり判定処理
    public void needle_hit_test_process()
    {
        // ライフゲージ消す
        if (life[2] != null)
        {
            Destroy(life[2].gameObject);
            heart_value--;// スター減らす
        }
        else if (life[1] != null)
        {
            Destroy(life[1].gameObject);
            heart_value--;// スター減らす
        }
        else if (life[0] != null)
        {
            Destroy(life[0].gameObject);
            heart_value--;// スター減らす
            goal_hit_test_process(); // 終了
        }
    }
}
