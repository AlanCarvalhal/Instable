using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    // declaracao de variaveis
    bool mouseOnObject;
    public Text missao;
    public Text dica;

    [Range(0.1f, 10.0f)] private float distancia = 4.5f;
    private GameObject Jogador;

    void Start()
    {
        //texto setado como falso para nao aparecer na tela no inico do jogo
        missao.enabled = false;
        //reconhecer o jogador
        Jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        //caso o jogador esteja mirando no objeto, em uma distancia menor que a definida e aperte F: inicia a missao do tutorial fazendo a dica sumir da tela
        if(mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            missao.enabled = true;
            dica.enabled = false;
        }
    }

    //se olhar pro item a booleana será verdadeira
    private void OnMouseEnter()
    {
        mouseOnObject = true;
    }

    //se parar de olhar pro item a booleana será falsa
    private void OnMouseExit()
    {
        mouseOnObject = false;
    }
}