using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    private int pontos;
    private AudioSource audioPontuacao;

    private void Awake()
    {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }
    public void adicionarPontos()
        {
            this.pontos++; 
            this.textoPontuacao.text = this.pontos.ToString();
            this.audioPontuacao.Play();
        }

    public void Reiniciar()
    {
        this.pontos = 0;
        this.textoPontuacao.text = this.pontos.ToString();
    }

}
