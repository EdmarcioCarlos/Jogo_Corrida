using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Som : MonoBehaviour
{
    [SerializeField] private AudioSource Musica;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Volume_Musica(float _Volume)
    {
        Musica.volume = _Volume;
    }
}
