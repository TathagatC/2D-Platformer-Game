using UnityEngine;
using UnityEngine.UI;

public class LobbyController : MonoBehaviour
{
    public Button startButton;
    public GameObject LevelSelection;

    private void Awake()
    {
        SoundManager.Instance.Play(Sounds.Background);
        startButton.onClick.AddListener(PlayGame);
    }

    private void PlayGame()
    {
        SoundManager.Instance.Play(Sounds.StartButtonClick);
        //SceneManager.LoadScene(1);
        LevelSelection.SetActive(true);
    }
}