using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Juego : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Empezar()
	{
		SceneManager.LoadScene("ShootCamp");
	}

	public void veropciones(){
		SceneManager.LoadScene("Opciones");
	}

	public void EscenaPrincipal()
	{
		SceneManager.LoadScene("MenuPrincipal");
	}

	public void Salir()
	{
		Application.Quit();
	}

}
