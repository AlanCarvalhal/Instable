using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public static int[] inventario = new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};    

    public static void Adicionar(int recurso, int valor)
    {
       inventario[recurso] += valor;       
    }

    public static void Remover(int valor, int recurso)
    {
       inventario[recurso] -= valor;
    }
}