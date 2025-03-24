using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Key.HaveKey == true)
        {
            if (Input.GetKey(KeyCode.W) == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
        }
    }
}
