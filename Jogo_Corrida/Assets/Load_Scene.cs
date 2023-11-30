using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load_Scene : MonoBehaviour
{
    [Header("Painels")]
    [SerializeField] private GameObject Painel_Tela_Load;
    [SerializeField] private GameObject Painel_Menu_Inicial;


    [Tooltip("Nome da fase que deve ser iniciar atualmente")]
    [SerializeField] private string Nome_Fase;


    [Header("Barra de Load")]
    [SerializeField] private Slider Barra_Load;
    [SerializeField] private TextMeshProUGUI Texto_Progressão;



    public void Carregar_Scene()
    {
        Painel_Tela_Load.SetActive(true);
        StartCoroutine(Tela_Load(Nome_Fase));

        SceneManager.LoadScene(Nome_Fase);
    }

    IEnumerator Tela_Load(string _Nome_Fase)
    {
        AsyncOperation OperadorLoad = SceneManager.LoadSceneAsync(_Nome_Fase);

        while(!OperadorLoad.isDone)
        {
            float Progressão = Mathf.Clamp01(OperadorLoad.progress/0.9f);
            Texto_Progressão.text = Progressão + "%"; 
            Barra_Load.value = Progressão;
            yield return null;
        }
    }
}