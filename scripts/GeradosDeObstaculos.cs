using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradosDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;
    [SerializeField]
    private GameObject manualDeInstrucoes;
    private float cronometro;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    void Update() {
        //Quando eu quero gerar? ->resposta: Tempo
        this.cronometro -= Time.deltaTime;
        if (this.cronometro < 0)
        {

            //Onde eu vou gerar? ->resposta: Na posição do meu gerador
            //Como criar novos obstáculos?
            GameObject.Instantiate(this.manualDeInstrucoes,this.transform.position,Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
