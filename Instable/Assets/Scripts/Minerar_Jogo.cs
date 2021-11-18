using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minerar_Jogo : MonoBehaviour
{
    
    bool mouseOnOre; 
    //Vector3 resize = new Vector3(1.0f, 1.0f, 1.0f);   
    private GameObject Jogador;    
    public AudioSource minerando;      

    void Start()
    {         
        Jogador = GameObject.FindWithTag("Player");              
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit;       
     
     if(Physics.Raycast(ray, out hit, 2.5f) && Input.GetKeyDown(KeyCode.F))
     {
       if(hit.transform.gameObject.CompareTag("arvore"))
       {
       Destroy(hit.transform.gameObject);       
       //minerando.Play();
       Inventario.Adicionar(0, 1);           
       }
       if(hit.transform.gameObject.CompareTag("pedra"))
       {
       hit.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);       
       //minerando.Play();
       Inventario.Adicionar(1, 1);
       }
       if(hit.transform.gameObject.CompareTag("azulita"))
       {
       hit.transform.localScale -= new Vector3(7.5f, 7.5f, 7.5f);      
       //minerando.Play();
       Inventario.Adicionar(2, 1); 
       }
       if(hit.transform.gameObject.CompareTag("ferro"))
       {
       hit.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);      
       //minerando.Play();
       Inventario.Adicionar(6, 1);
       }       
       if(hit.transform.gameObject.CompareTag("rosita"))
       {
       hit.transform.localScale -= new Vector3(4.5f, 4.5f, 3.0f);      
       //minerando.Play();
       Inventario.Adicionar(4, 1); 
       }
       if(hit.transform.gameObject.CompareTag("fireore"))
       {
       hit.transform.localScale -= new Vector3(7.5f, 7.5f, 6.0f);      
       //minerando.Play();
       Inventario.Adicionar(5, 1);
       }       
       if(hit.transform.gameObject.CompareTag("cactus"))
       {
       hit.transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f);      
       //minerando.Play();
       Inventario.Adicionar(8, 1);
       }
       if(hit.transform.gameObject.CompareTag("palmeira"))
       {
       hit.transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f);      
       //minerando.Play();
       Inventario.Adicionar(7, 1); 
       }      
       if(hit.transform.gameObject.CompareTag("coral_lunar"))
       {
       hit.transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f);      
       //minerando.Play();
       Inventario.Adicionar(9, 1); 
       }
       if(hit.transform.gameObject.CompareTag("obsidian"))
       {
       hit.transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f);      
       //minerando.Play();
       Inventario.Adicionar(3, 1);
       }      
      }       
    }    
}
