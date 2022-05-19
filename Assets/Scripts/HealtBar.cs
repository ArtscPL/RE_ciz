using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBar : MonoBehaviour
{
    private Image Health_bar;
    public float CurrentHealth;
    private float MaxHealth;
    Character player;
    void Start()
    {
        Health_bar = GetComponent<Image>();
        player = FindObjectOfType<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        MaxHealth = player.Health.Value;
        CurrentHealth = player.Health00;

        Health_bar.fillAmount = CurrentHealth/MaxHealth;
    }
}
