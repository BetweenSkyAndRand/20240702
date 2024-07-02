using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);      
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void StartGame()
    {
        ScenData.score = 0;
        SceneManager.LoadScene("Game");
    }
    //ÉQÅ[ÉÄèIóπ
    public void EndGame()
    {
        ScenData.score = ScoreScript.instance.GetCurrentScore();
        SceneManager.LoadScene("Result");
    }

    // Update is called once per frame
    public void ReturnStart()
    {
        SceneManager.LoadScene("Start");
    }
}
