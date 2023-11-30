using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controlador_MenuInicial : MonoBehaviour
{
    [Tooltip("Anexar os menus inicias do jogo para funcionamento da scene Menu_Inicial")]
    [SerializeField] private GameObject Menu_Inicial,
                                        Menu_Config;

    [SerializeField] private GameObject Controlador_TelaLoade;
    public void Awake()
    {
        Menu_Inicial.SetActive(true);
        Menu_Config.SetActive(false);
    }
    public void Ativar_Config()
    {
        Menu_Config.SetActive(true);
        Menu_Inicial.SetActive(false);
    }
    
    public void Voltar()
    {
        Menu_Config.SetActive(false);
        Menu_Inicial.SetActive(true);
    }

    public void Iniciar()
    {
        Controlador_TelaLoade.GetComponent<Load_Scene>().Carregar_Scene();
    }
    public void Sair_Jogo()
    {
        Debug.Log("Saindo");
        Application.Quit();
    }
}
