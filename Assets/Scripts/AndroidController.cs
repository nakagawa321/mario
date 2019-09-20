using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidController : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    bool right = false;
    //  右ボタンを押しているかの真偽値
    bool left = false;
    //  左ボタンを押しているかの真偽値
    private float speed = 0.1f;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            animator.SetBool("is_running", true); // アニメーション開始
            goright();
            //          右に動かすためのメソッドを呼び出す
        }
        else if (left)
        {
            animator.SetBool("is_running", true); // アニメーション開始
            goleft();
            //          左に動かすためのメソッドを呼び出す
        } else
        {
            animator.SetBool("is_running", false); // アニメーション停止
        }

    }

    public void rPushDown()
    {
        //      右ボタンを押している間
        right = true;
    }

    public void rPushUp()
    {
        //      右ボタンを押すのをやめた時
        right = false;
    }

    public void lPushDown()
    {
        //      左ボタンを押している間
        left = true;
    }

    public void lPushUp()
    {
        //      左ボタンを押すのをやめた時
        left = false;
    }

    public void goright()
    {
        player.transform.Translate(0, 0, this.speed);
    }

    public void goleft()
    {
        player.transform.Translate(0, 0, -this.speed);
    }


}
