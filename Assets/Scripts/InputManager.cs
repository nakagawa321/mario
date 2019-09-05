using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public MusicManager musicmanager = new MusicManager();
    public CollisionManager collisionManager = new CollisionManager();
    public Control control = new Control(); // コントロールスクリプト
    public GameObject Teddy;
    public Rigidbody rb;
    private float speed = 1000.0f; // 移動スピード
    private float landing_position = -5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = Teddy.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // 入力処理
        float x = Input.GetAxis("Horizontal");

        if (Teddy != null) // finishシーンでも受け継がれている(音楽のため)
        {
            rb.AddForce(x * speed, Teddy.transform.position.y, 0);

            // ジャンプ処理
            if (control.Getjump_judgement() == true && Input.GetKeyDown("space"))
            {
                rb.AddForce(Vector3.up * 2500); // 飛ぶ処理
                control.Setjump_judgement(false);
            }
        }
        // android版



        // 落下ゲームオーバー処理
        if (Teddy != null)
        {
            if (Teddy.transform.position.y < landing_position)
            {
                musicmanager.Play_sound4(); // 落下音
                CollisionManager.heart_value = 0; // 星はゼロに
                collisionManager.goal_hit_test_process(); // 終了
            }
        }

    }
}
