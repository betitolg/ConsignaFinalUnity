using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubManager : MonoBehaviour
{



    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private GameObject HPBar;
    private static HubManager instance;
    public static HubManager Instance
    {
        get => instance;
    }


    private void Awake()
    {
        GameOverPanel.SetActive(false);
        if (instance==null)
        {


            PlayerCollision.OnDead += GameOver;
            PlayerCollision.OnChangeHP += SetHPBar;
        }
        else
        {Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GameOver()
    {
        GameOverPanel.SetActive(true);
        Debug.Log("Respuesta desde otro script");
    }

    public static void SetHPBar(int newValue)
    {
        
        
    }

    private void OnDisable()
    {
       
    }
}
