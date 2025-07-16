using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        // Carga la escena que tiene tu juego.
        // Asegúrate de que el nombre "GameScene" coincida exactamente con el de tu archivo de escena.
        SceneManager.LoadScene("SampleScene");
    }
}