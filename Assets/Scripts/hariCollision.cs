using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hariCollision : MonoBehaviour
{
    public MusicManager musicmanager = new MusicManager();
    public CollisionManager collisionManager = new CollisionManager();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        collisionManager.needle_hit_test_process(); //コリジョンマネージャ呼び出し
        musicmanager.Play_sound3(); // 針の音

    }
}
