using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pc_Tuto : MonoBehaviour
{
    // declaracao de variaveis
    bool mouseOnObject;
    public Text missao;
    public Text dica;
    public static bool tutorial = false;
    private GameObject Jogador;
    [Range(0.1f, 10.0f)] private float distancia = 4.5f;

    void Start()
    {
        missao.enabled = false;
        Jogador = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (Minerar_Tuto.azulita_tutorial == 7 && mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            //GameObject.Find("generator").SetActive(true);
        }
        if (mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            GameObject.Find("generator").SetActive(true);
            missao.enabled = true;
            dica.enabled = false;
            tutorial = true;
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