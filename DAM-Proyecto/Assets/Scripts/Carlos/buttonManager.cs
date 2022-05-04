using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class buttonManager : MonoBehaviour
{
    //Este método me permite cargar escenas (por lo general tendremos solo dos o tres escenas, pero siempre va bien tener un metido así)
    public void LoadScene(int escena){
      //para utilizar esta funcion hay que importar UnityEngine.SceneManagement. Las escenas estan numeradas, carga la escena con el número indicado.
      SceneManager.LoadScene(escena);
    }

  //Método para cerrar el juego.
    public void Exit(){
      //esta parte del codigo es para testeo en el editor de unity, posiblemente para el juego final se quitará y se dejará solo el Application.Quit() (esta funcion cierra el juego)
      //NO ESTOY SEGURO DE QUE FUNCIONE EN SMARTPHONE, TENGO QUE PROBARLO.
      #if UNITY_EDITOR
      UnityEditor.EditorApplication.ExitPlaymode();
      #else
      Application.Quit();
      #endif
    }

  //Método para activar y desactivar cualquier objeto del juego, seguramente lo use solo para menús y similares.
    public void Menu(GameObject menu){
      //Si el gameobject está activo, lo desactiva.
      if(menu.activeInHierarchy){//Esta funcion detecta si esta activo
          menu.SetActive(false); //Esta función lo desactiva
      }else{
          menu.SetActive(true);//Esta funcion lo activa
    }
    }
}
