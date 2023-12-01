using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador_MenuInicial : MonoBehaviour
{
    [Tooltip("Anexar os menus inicias do jogo para funcionamento da scene Menu_Inicial")]
    [SerializeField] private GameObject Menu_Inicial;
    [SerializeField] private GameObject Menu_Config;
    [SerializeField] private GameObject Controlador_TelaLoad;




    [Tooltip("Nome da fase que deve ser iniciar atualmente")]
    [SerializeField] private string Nome_Fase;


    [Header("Barra de Load")]
    [SerializeField] private Slider Barra_Load;
    [SerializeField] private TextMeshProUGUI Texto_Progressão ;

    public void Awake()
    {
        Menu_Inicial.SetActive(true);
        Menu_Config.SetActive(false);
        Controlador_TelaLoad.SetActive(false);
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
        Controlador_TelaLoad.SetActive(true);
        Carregar_Scene();


    }
    public void Sair_Jogo()
    {
        Debug.Log("Saindo");
        Application.Quit();
    }

    public void Carregar_Scene()
    {
        StartCoroutine(Tela_Load(Nome_Fase));
    }

    IEnumerator Tela_Load(string _Nome_Fase)
    {
        AsyncOperation OperadorLoad = SceneManager.LoadSceneAsync(_Nome_Fase);

        while(!OperadorLoad.isDone)
        {
            float Progressão = Mathf.Clamp01(OperadorLoad.progress/0.1f);
            Texto_Progressão.text = Progressão + "%"; 
            Barra_Load.value = Progressão;
            yield return null;
        }
    }
}