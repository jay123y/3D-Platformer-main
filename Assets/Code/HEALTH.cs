using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class HEALTH : MonoBehaviour
{
    public float health = 100;
    public int coins = 0;
    public Slider healthSlider;
    public TextMeshProUGUI coinText;


    void Start(){
        healthSlider.maxValue = health;
        healthSlider.value = health;
        coinText.text = coins.ToString();
    }

    public void TakeDamage(float damage){
        health -= damage;
        healthSlider.value = health;
        if (health < 0){
            SceneManager.LoadScene(0);
        }
    }
    public void collectCoins (int amount){
    coins += amount;
    coinText.text = coins.ToString();
    }
}