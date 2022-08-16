using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    private Loading loading = new Loading();

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    
    void Start()
    {
        SceneManager.LoadScene(1);
        StartCoroutine(loading.LoadingScene());
    }

    void Update()
    {

    }
}
