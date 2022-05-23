using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverScript : MonoBehaviour
{
    public void LoadSelector()
    {
        SceneManager.LoadScene("Level Select");
    }
}
