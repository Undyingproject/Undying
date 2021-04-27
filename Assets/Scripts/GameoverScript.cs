using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverScript : MonoBehaviour
{
	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void Back ()
	{
		SceneManager.LoadScene("écran d'accueil");
	}
}
