using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class android_jump : MonoBehaviour
{
    public Animator animator;
    public Control control = new Control(); // コントロールスクリプト
    public GameObject Teddy;
    public Rigidbody rb;
    public MusicManager musicManager = new MusicManager();

    // Start is called before the first frame update
    void Start()
    {
        rb = Teddy.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        if (control.Getjump_judgement() == true)
        {
            animator.SetTrigger("is_jump"); // アニメーション
            rb.AddForce(Vector3.up * 2500); // 飛ぶ処理
            control.Setjump_judgement(false); // 地面と触れていない
            musicManager.Play_sound1(); //音楽
        }
    }
}
