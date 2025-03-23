using System.Security;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<Transform>().position = new Vector3(-8, -4.5f, 0);
        }
    }
}
