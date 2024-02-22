using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Main_Scene : MonoBehaviour
{
    public static UI_Main_Scene instance;

    public TextMeshProUGUI playerHealthText;
    public GameObject gameOverText;

    public bool isGameActive;



    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);

        }
        else 
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        
        isGameActive = true;
    }

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePlayerHealth(int currentHealth) 
    {
        if (currentHealth > 0)
        {
            playerHealthText.text = "Health: " + currentHealth;

        }
        else 
        {
            playerHealthText.text = "Health: " + 0;

        }


    }

    public void GameOver()
    {
        //set game over text true    
        gameOverText.SetActive(true);
        isGameActive = false;
    
    }

}
