using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitboxPlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("win"))
        {
            SceneManager.LoadScene("Level2");
        }

        if(collision.collider.CompareTag("win2"))
        {
            SceneManager.LoadScene("Level3");
        }

        if(collision.collider.CompareTag("win3"))
        {
            SceneManager.LoadScene("End");
        }
    }
}
