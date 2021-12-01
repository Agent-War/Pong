using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    int sc1,sc2;
    public Spawn s;
    // Start is called before the first frame update
    void Start()
    {
        sc1 = 0;
        sc2 = 0;
    }

    public void scoreup1()
    {
        sc1++;
        if (sc1 < 10)
        {
            GetComponent<Text>().text = sc1.ToString();
            
           
           
        }
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void scoreup2()
    {
        sc2++;
        if (sc2 < 10)
        {
            GetComponent<Text>().text = sc2.ToString();
           
        }
      
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
