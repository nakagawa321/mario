using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalCollision : MonoBehaviour
{
    public MusicManager musicmanager = new MusicManager();
    public CollisionManager collisionmanager = new CollisionManager();


    // Start is called before the first frame update
    void Start()
    {
        //画面遷移してもオブジェクトが壊れないようにする
        DontDestroyOnLoad(musicmanager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ゴールに行くと
    void OnTriggerEnter(Collider t)
    {
        musicmanager.Play_sound2(); // ミュージックマネージャ呼び出し
        collisionmanager.goal_hit_test_process(); // コリジョンマネージャ呼び出し
    }
}
