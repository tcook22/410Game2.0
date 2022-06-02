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
    public GameObject Projectile;
   

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
        if(other.transform.tag == "Projectile"){
            Destroy(other.gameObject);
        }
        if(other.transform.tag == "Shield"){
            Destroy(other.gameObject);
        }
        if(other.transform.tag == "Transparent"){
            Destroy(other.gameObject);
        }
        if(other.transform.tag == "Rocks")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
            //gameoverscreen.SetActive(true);
        
        }
            
    }

    public void ReplayLevel()
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
