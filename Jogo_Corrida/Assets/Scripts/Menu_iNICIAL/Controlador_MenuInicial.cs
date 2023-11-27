using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador_MenuInicial : MonoBehaviour
{
    [Tooltip("Anexar os menus inicias do jogo para funcionamento da scene Menu_Inicial")]
    public GameObject Menu_Inicial,
                      Menu_Config;

    public void Start()
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

    }

    public void Sair_Jogo()
    {
    
    }
}
