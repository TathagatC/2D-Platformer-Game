using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using TMPro;

public class GameOverController : MonoBehaviour
{
    public Button restartButton;
    public Button mainMenuButton;

    private void Awake()
    {
        restartButton.onClick.AddListener(ReloadLevel);
        mainMenuButton.onClick.AddListener(MainScene);
    }

    public void PlayerDied()
    {
        gameObject.SetActive(true);
    }

    private void ReloadLevel ()
    {
        SoundManager.Instance.Play(Sounds.BackButtonClick);
        Debug.Log("Reloading Scene ........");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }

    private void MainScene()
    {
        SoundManager.Instance.Play(Sounds.BackButtonClick);
        SceneManager.LoadScene(0);
    }
}
