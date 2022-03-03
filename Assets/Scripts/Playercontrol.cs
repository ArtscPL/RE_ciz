using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Playercontrol : MonoBehaviour
{
    [Range(0.0f, 100.0f)] public float Health = 100f;
    [SerializeField] private GameObject player = null;
    [SerializeField] private GameObject Enemy = null;
    [SerializeField] private Slider player_hp = null;
    private int enemy_hp;
    private Random_Enemy_HP R_hp;
    void Start()
    {
        R_hp = FindObjectOfType<Random_Enemy_HP>();
        //enemy_hp = R_hp.HP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
