using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour

{
    public GameObject gameoverscreen;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Lava")
        {
            gameoverscreen.SetActive(true);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
