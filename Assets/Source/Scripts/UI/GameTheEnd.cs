using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTheEnd : MonoBehaviour
{
    public const int NumberMenuScene = 0;

    [SerializeField] private Button _exitButton;

    private void OnEnable() => _exitButton.onClick?.AddListener(OnExitClick);

    private void OnDisable() => _exitButton.onClick?.RemoveListener(OnExitClick);

    private void OnExitClick() => SceneManager.LoadScene(NumberMenuScene);
}