using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screen_transition_finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Quit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return") && SceneManager.GetActiveScene().name == "Finish")
        {
            Quit();
        }
        // android版
        if (Input.touchCount > 0 && SceneManager.GetActiveScene().name == "Finish")
        {
            // タッチ情報の取得
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Application.Quit();
            }

        }
    }
}
