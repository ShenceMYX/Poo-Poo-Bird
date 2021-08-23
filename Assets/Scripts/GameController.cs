using System.Collections;
using System.Collections.Generic;
using Common;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoSingleton<GameController>
{
    public int currentSceneIndex;
    public AudioClip rebornClip;
    private AudioSource source;

    public override void Init()
    {
        base.Init();
        source = gameObject.AddComponent<AudioSource>();
        source.playOnAwake = false;
    }

    public void RestartGame()
    {
        source.Play();
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadNextScene()
    {
        currentSceneIndex++;
        source.Play();
        SceneManager.LoadScene(currentSceneIndex);
    }
}
