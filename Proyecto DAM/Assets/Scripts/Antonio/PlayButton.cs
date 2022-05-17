<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

	public void OnClickPlay()
	{
		GameController gameController = GameObject.FindGameObjectWithTag("Game").GetComponent<GameController>();
		SceneManager.LoadScene("Juego", LoadSceneMode.Single);
		gameController.GetComponent<AudioSource>().clip = gameController.clips[1];
		gameController.GetComponent<AudioSource>().Play();
	}
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

	public void OnClickPlay()
	{
		GameController gameController = GameObject.FindGameObjectWithTag("Game").GetComponent<GameController>();
		SceneManager.LoadScene("Juego", LoadSceneMode.Single);
		gameController.GetComponent<AudioSource>().clip = gameController.clips[1];
		gameController.GetComponent<AudioSource>().Play();
	}
}
>>>>>>> parent of 3b68fc4 (Revert "Merge branch 'main' of https://github.com/charlinchui/DAM")
