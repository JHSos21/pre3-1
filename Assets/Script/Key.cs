using Unity.VisualScripting;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static bool HaveKey;
    void Awake()
    {
        HaveKey = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HaveKey = true;
        this.gameObject.SetActive(false);
    }
}
