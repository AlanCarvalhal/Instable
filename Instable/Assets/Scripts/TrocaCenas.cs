using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCenas : MonoBehaviour
{
    bool mouseOnObject;
    public Scene cena;
    private GameObject Jogador;
    [Range(0.1f, 10.0f)] private float distancia = 3.5f;

    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseOnObject == true && Vector3.Distance(transform.position, Jogador.transform.position) < distancia && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(3);
        }
    }
    private void OnMouseEnter()
    {
        mouseOnObject = true;
    }

    private void OnMouseExit()
    {
        mouseOnObject = false;
    }
}
