using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minerar_Jogo : MonoBehaviour
{
    
    bool mouseOnOre; 
    Vector3 resize = new Vector3(5.0f, 5.0f, 5.0f);   
    private GameObject Jogador;
    private GameObject minerio;       
    public AudioSource minerando;    

    void Start()
    {         
        Jogador = GameObject.FindWithTag("Player");       
        minerio = GameObject.FindWithTag("Minerio");        
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit;       
     
     if(Physics.Raycast(ray, out hit, 2.5f) && Input.GetKeyDown(KeyCode.F))
     {
       //transform.localScale = transform.localScale - resize; (consertar pra dar resize no objeto olhado)
       //adicionar no inventario dependendo qual for
        minerando.Play(); 
     }       
    }    
}