using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_MusicManager : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //画面遷移してもオブジェクトが壊れないようにする
        DontDestroyOnLoad(this);

        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // エンター
        if (Input.GetKeyDown("return") && SceneManager.GetActiveScene().name == "Start")
        {
            //音(sound1)を鳴らす
            audioSource.PlayOneShot(sound1);
        }
        // android版
        if (Input.touchCount > 0 && SceneManager.GetActiveScene().name == "Start")
        {
            // タッチ情報の取得
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                //音(sound1)を鳴らす
                audioSource.PlayOneShot(sound1);
            }

        }
    }
}
