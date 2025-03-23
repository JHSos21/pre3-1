using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    int SceneNum=1;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Key.HaveKey == true)
        {
            if (Input.GetKey(KeyCode.W) == true)
            {
                SceneManager.LoadScene(SceneNum);
                SceneNum++;
            }
        }
    }
}
