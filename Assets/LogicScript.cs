using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameOverScreen;
    public Text myscore; 
    private int Scorenum;
    public void Addsc()
    {
        Scorenum = 0;
        myscore.text = "Score: " + Scorenum.ToString();
    }
    
    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
    public void GameOver(){
        GameOverScreen.SetActive(true);
    }
    

}
