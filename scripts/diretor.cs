using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject ImagemGameOver;
    private Aviao viao;
    private pontuacao pontuacao;

    private void Start()
    {
        this.viao = GameObject.FindObjectOfType<Aviao>();
        this.pontuacao = GameObject.FindObjectOfType<pontuacao>();
    }
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        this.ImagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        this.ImagemGameOver.SetActive(false);
        Time.timeScale = 1;
        this.viao.Reiniciar();
        this.DestruirObstaculos();
        this.pontuacao.Reiniciar();
    }

    private void DestruirObstaculos()
    {
        Obstaculo [] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
