using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public const int NumberStartGameScene = 1;

    [SerializeField] private Button _startGame;
    [SerializeField] private Button _exitGame;

    private void OnEnable()
    {
        _startGame.onClick?.AddListener(OnClickStartGame);
        _exitGame.onClick?.AddListener(OnClickExitGame);
    }

    private void OnDisable()
    {
        _startGame.onClick?.RemoveListener(OnClickStartGame);
        _exitGame.onClick?.RemoveListener(OnClickExitGame);
    }

    private void OnClickStartGame()
    {
        SceneManager.LoadScene(NumberStartGameScene);
    }

    private void OnClickExitGame()
    {
        Application.Quit();
    }
}