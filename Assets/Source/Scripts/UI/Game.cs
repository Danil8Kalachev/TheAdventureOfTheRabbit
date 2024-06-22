using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}