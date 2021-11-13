using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minerar_Tuto : MonoBehaviour
{
    // declaracao de variaveis
    public static int azulita_tutorial;  
    bool mouseOnObject; 
    Vector3 resize = new Vector3(5.0f,5.0f,5.0f);                 

    [Range(0.1f, 10.0f)] private float distancia = 3.5f;
    private GameObject Jogador;

    void Start()
    {        
        //reconhecer o jogador
        Jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        //caso o jogador esteja mirando no objeto, em uma distancia menor que a definida e aperte F: inicia a missao do tutorial fazendo a dica sumir da tela
        if(Pc_Tuto.tutorial == true && mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            transform.localScale = transform.localScale - resize; 
            azulita_tutorial++;                      
        }
    }

    //se olhar pro item a booleana ser verdadeira
    private void OnMouseEnter()
    {
        mouseOnObject = true;
    }

    //se parar de olhar pro item a booleana ser falsa
    private void OnMouseExit()
    {
        mouseOnObject = false;
    }
}