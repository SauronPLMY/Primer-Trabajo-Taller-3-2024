using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;            
    public TextMeshProUGUI textMeshPro; 

    void Start()
    {
       

                             
        UpdateText();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
            UpdateText();                            
        }
    }

    
    
    
    void UpdateText()
    {
        textMeshPro.text = "Score: " + score.ToString();        
    }
}
