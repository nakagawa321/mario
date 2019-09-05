using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public GameObject mainCamera; //カメラオブジェクト
    private bool jump_judgement = false; // ジャンプできるか
    int character_height = 1;
    //z軸を調整。正の数ならプレイヤーの前に、負の数ならプレイヤーの後ろに配置する
    private int zAdjust = -10;

    //ゲッター
    public bool Getjump_judgement()
    {
        return this.jump_judgement;
    }

    //セッター
    public void Setjump_judgement(bool jump_judgement)
    {
        this.jump_judgement = jump_judgement;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //カメラはプレイヤーと同じ位置にする
        mainCamera.transform.position = new Vector3(transform.position.x, character_height, transform.position.z + zAdjust);
    }

    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        Setjump_judgement(true);

    }

}
