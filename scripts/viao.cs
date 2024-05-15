using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
	private Rigidbody2D fisica;
	[SerializeField]
	private float forca;
	private diretor diretor;
	private Vector3 posicaoInicial;

    private void Awake()
    {
		this.posicaoInicial = this.transform.position;
		this.fisica = this.GetComponent<Rigidbody2D>();
	
    }

	private void Start()
	{
        this.diretor = GameObject.FindObjectOfType<diretor>();
    }

	private void Update()
	{
		if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
			this.Impulsionar();
		}
	}

	public void Reiniciar()
	{
		this.transform.position = posicaoInicial;
		this.fisica.simulated = true;
	}

	private void Impulsionar()
	{
		this.fisica.velocity = Vector2.zero;
		this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);	
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
		this.fisica.simulated = false;
		this.diretor.FinalizarJogo();
    }
}

