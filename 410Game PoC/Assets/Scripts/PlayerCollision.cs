using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour

{
    public GameObject player;
    public GameObject Angel;
    public GameObject gameoverscreen;
   

    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Lava")
        {
            gameoverscreen.SetActive(true);
        
        }
        if(other.transform.tag == "Angel"){
            Destroy(other.gameObject);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
