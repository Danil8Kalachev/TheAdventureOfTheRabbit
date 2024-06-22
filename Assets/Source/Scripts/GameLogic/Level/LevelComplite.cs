using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplite : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerMovement playerMovement))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}