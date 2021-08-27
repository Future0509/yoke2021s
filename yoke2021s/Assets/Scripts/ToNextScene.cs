using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToNextScene : MonoBehaviour
{
    [Tooltip("title"), SerializeField]
    string nextScene = "";

    bool sceneChanged;

    public void ChangeScene()
    {
        if (sceneChanged) return;

        sceneChanged = true;
        TinyAudio.PlaySE(TinyAudio.SE.Magic);
        SceneManager.LoadScene(nextScene);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
