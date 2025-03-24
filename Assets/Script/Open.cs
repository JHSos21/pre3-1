using UnityEngine;

public class Open : MonoBehaviour
{
    public static bool OffSpike;
    void Awake()
    {
        OffSpike = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        OffSpike = true;
        this.gameObject.SetActive(false);
    }
}
