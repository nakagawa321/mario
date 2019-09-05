using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public Control control = new Control(); // コントロールスクリプト
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        // ジャンプ
        if (control.Getjump_judgement() == true && Input.GetKeyDown(KeyCode.Space))
        {
            //音(sound1)を鳴らす
            audioSource.PlayOneShot(sound1); // ジャンプ音
           
        }


    }

    public void Play_sound1()
    {
        audioSource.PlayOneShot(sound1); // ジャンプ音
    }

    // サウンド２_ゴールの当たり判定の時
    public void Play_sound2()
    {
        audioSource.PlayOneShot(sound2); //トランペット
    }

    // 針の音
    public void Play_sound3()
    {
        audioSource.PlayOneShot(sound3); //針
    }

    // 落下の音
    public void Play_sound4()
    {
        audioSource.PlayOneShot(sound4); //落下
    }
}
