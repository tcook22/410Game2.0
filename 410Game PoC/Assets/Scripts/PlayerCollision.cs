using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCollision : MonoBehaviour

{
    public GameObject player;
    public GameObject Angel;
    public GameObject gameoverscreen;
   

    private void OnCollisionEnter(Collision other)
    {
        
        if(other.transform.tag == "Lava")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
            //gameoverscreen.SetActive(true);
        
        }
        if(other.transform.tag == "Princess" || Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("LevelOver");
        }
        if(other.transform.tag == "Angel"){
            Destroy(other.gameObject);
        }
    }

    public void ReplayLevel()
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
