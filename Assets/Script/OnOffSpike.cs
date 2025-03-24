using UnityEngine;

public class OnOffSpike : MonoBehaviour
{
    void Update()
    {
        if (Open.OffSpike == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
